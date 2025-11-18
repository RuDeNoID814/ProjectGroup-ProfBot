using ProjectGroup.models;
using ProjectGroup.services;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace ProjectGroup.handlers;

// Обработка нажатий кнопок
public static class CallbackHandler
{
    private static readonly SessionService _sessionService = new SessionService();
    private static readonly QuestionService _questionService = new QuestionService();
    private static readonly ResultService _resultService = new ResultService();

    // Главный обработчик всех callback
    public static async Task HandleCallback(CallbackQuery callback, ITelegramBotClient botClient)
    {
        Console.WriteLine($"[CallbackHandler] Получен callback: {callback.Data}");
        
        var data = callback.Data;
        var chatId = callback.Message!.Chat.Id;
        var telegramId = callback.From.Id;
        
        // Убираем часики у кнопки
        await botClient.AnswerCallbackQuery(callback.Id);

        try
        {
            if (data == "start_test")
            {
                await HandleStartTest(chatId, telegramId, botClient);
            }
            else if (data == "main_menu")
            {
                await HandleMainMenu(chatId, botClient);
            }
            else if (data == "about")
            {
                await HandleAbout(chatId, botClient);
            }
            else if (data == "restart_test")
            {
                _sessionService.EndSession(telegramId);
                await HandleStartTest(chatId, telegramId, botClient);
            }
            else if (data.StartsWith("answer_"))
            {
                await HandleAnswer(chatId, telegramId, data, botClient);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[ERROR] Ошибка в HandleCallback: {ex.Message}");
            await botClient.SendMessage(chatId, "❌ Произошла ошибка. Попробуй /start");
        }
    }

    // Начать тест
    private static async Task HandleStartTest(long chatId, long telegramId, ITelegramBotClient bot)
    {
        Console.WriteLine($"[DEBUG] HandleStartTest вызван для telegramId: {telegramId}");
        
        // Создаем новую сессию
        var session = _sessionService.CreateSession(telegramId);
        Console.WriteLine($"[DEBUG] Сессия создана");
        
        // Показываем первый вопрос
        await ShowQuestion(chatId, session, bot);
    }
    
    // Показать главное меню
    private static async Task HandleMainMenu(long chatId, ITelegramBotClient bot)
    {
        var keyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("🧪 Пройти тест", "start_test")
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("ℹ️ О проекте", "about")
            }
        });

        await bot.SendMessage(
            chatId: chatId,
            text: "👋 Привет! Я бот для профориентации в ЧелГУ.\n\n" +
                  "Я помогу тебе выбрать подходящий факультет на основе твоих интересов и навыков.\n\n" +
                  "Нажми кнопку ниже, чтобы начать!",
            replyMarkup: keyboard
        );
    }
    
    // Показать вопрос
    private static async Task ShowQuestion(long chatId, UserSession session, ITelegramBotClient botClient)
    {
        var question = _questionService.GetQuestionById(session.CurrentQuestionId);

        if (question == null)
        {
            await botClient.SendMessage(chatId, "❌ Ошибка: вопрос не найден!"); 
            return;
        }
        
        // Создаем кнопки с ответами
        var buttons = question.Answers.Select((answer, index) => new[]
        {
            InlineKeyboardButton.WithCallbackData(
                answer.Text,
                $"answer_{session.CurrentQuestionId}_{index}")
        }).ToArray();
        
        var keyboard = new InlineKeyboardMarkup(buttons);
        
        // Определяем номер вопроса для пользователя
        var questionNumber = session.AnsweredQuestions.Count + 1;
        var totalQuestions = 5; // пока только общие вопросы
        
        await botClient.SendMessage(
            chatId: chatId,
            text: $"❓ Вопрос {questionNumber}/{totalQuestions}\n\n{question.Text}",
            replyMarkup: keyboard
        );
    }
    
    // Обработка ответа на вопрос
    private static async Task HandleAnswer(long chatId, long telegramId, string data, ITelegramBotClient botClient)
    {
        // Парсим данные: "answer_1_0" -> questionId=1, answerIndex=0
        var parts = data.Split('_');
        var questionId = int.Parse(parts[1]);
        var answerIndex = int.Parse(parts[2]);
        
        // Получаем сессию
        var session = _sessionService.GetSession(telegramId);
        if (session == null)
        {
            await botClient.SendMessage(chatId, "❌ Сессия не найдена. Начни тест заново.");
            return;
        }
        
        // Получаем вопрос и ответ
        var question = _questionService.GetQuestionById(questionId);
        var answer = question!.Answers[answerIndex];
        
        // Добавляем баллы
        foreach (var faculty in answer.FacultyScores)
        {
            if (!session.FacultyScores.ContainsKey(faculty.Key))
                session.FacultyScores[faculty.Key] = 0;
            
            session.FacultyScores[faculty.Key] += faculty.Value;
        }
        
        // Добавляем в историю
        session.AnsweredQuestions.Add(questionId);
        
        // Проверяем, есть ли еще общие вопросы
        if (_questionService.HasMoreGeneralQuestions(questionId))
        {
            var nextQuestion = _questionService.GetNextGeneralQuestion(questionId);
            session.CurrentQuestionId = nextQuestion!.Id;
            _sessionService.UpdateSession(session);
            
            await ShowQuestion(chatId, session, botClient);
        }
        else
        {
            // Общие вопросы закончились
            await ShowResult(chatId, session, botClient);
        }
    }
    
    // Показать результат теста
    private static async Task ShowResult(long chatId, UserSession session, ITelegramBotClient botClient)
    {
        // Определяем лидера
        var leadingFaculty = _resultService.GetLeadingFaculty(session.FacultyScores);
        
        // Завершаем сессию
        _sessionService.EndSession(session.TelegramId);
        
        // Формируем текст результата
        var facultyNames = new Dictionary<string, string>
        {
            { "IIT", "Институт Информационных Технологий" },
            { "Math", "Математический факультет" },
            { "Physics", "Физический факультет" },
            { "Chemistry", "Химический факультет" },
            { "Economics", "Факультет экономики и управления" }
        };

        var resultText = $"🎓 Результаты теста:\n\n" +
                         $"Тебе больше всего подходит:\n" +
                         $"✨ {facultyNames[leadingFaculty]}\n\n" +
                         $"Твои баллы:\n";

        foreach (var faculty in session.FacultyScores.OrderByDescending(f => f.Value))
        {
            resultText += $"• {facultyNames[faculty.Key]}: {faculty.Value} баллов\n";
        }

        resultText += "\n💡 Это базовый результат на основе общих вопросов. " +
                      "В будущем будут добавлены адаптивные вопросы для более точной рекомендации!";

        var keyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("🔄 Пройти заново", "restart_test")
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("🏠 Главное меню", "main_menu")
            }
        });

        await botClient.SendMessage(
            chatId: chatId,
            text: resultText,
            replyMarkup: keyboard
        );
    }
    
    // О проекте
    private static async Task HandleAbout(long chatId, ITelegramBotClient botClient)
    {
        var keyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("🏠 Главное меню", "main_menu")
            }
        });
        
        await botClient.SendMessage(
            chatId: chatId,
            text: "ℹ️ О проекте:\n\n" +
                  "Этот бот создан студентами ЧелГУ для помощи абитуриентам в выборе факультета.\n\n" +
                  "Команда:\n" +
                  "• Максим Руденко\n" +
                  "• Дарья Пономаренко\n" +
                  "• Алёна Колесова\n" +
                  "• Нарек Месробян\n" +
                  "• Марк Черепанов\n" +
                  "• Анна Журкина",
            replyMarkup: keyboard
        );
    }
}