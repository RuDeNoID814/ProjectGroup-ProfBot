using ProjectGroup.models;
using ProjectGroup.services;
using ProjectGroup.data;
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
            else if (data.StartsWith("faculty_info_"))
            {
                var facultyCode = data.Replace("faculty_info_", "");
                await ShowFacultyInfo(chatId, facultyCode, botClient);
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
        
        // Определяем номер вопроса и тип
        string questionHeader;

        if (question.Type == QuestionType.General)
        {
            var questionNumber = session.AnsweredQuestions.Count + 1;
            var totalQuestions = 5; // общие вопросы
            questionHeader = $"❓ Вопрос {questionNumber}/{totalQuestions}";
        }
        else // Adaptive
        {
            questionHeader = "🎯 Дополнительный вопрос";
        }

        await botClient.SendMessage(
            chatId: chatId,
            text: $"{questionHeader}\n\n{question.Text}",
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
        
        // Добавляем баллы направлениям
        foreach (var direction in answer.DirectionScores)
        {
            if (!session.DirectionScores.ContainsKey(direction.Key))
                session.DirectionScores[direction.Key] = 0;
    
            session.DirectionScores[direction.Key] += direction.Value;
    
            Console.WriteLine($"[HandleAnswer] Направление {direction.Key}: +{direction.Value} баллов");
        }

        // Добавляем в историю
        session.AnsweredQuestions.Add(questionId);

        // Проверяем, есть ли ещё общие вопросы
        var currentQuestion = _questionService.GetQuestionById(questionId);

        // Если это общий вопрос
        if (currentQuestion!.Type == QuestionType.General)
        {
            // Проверяем, есть ли ещё общие вопросы
            if (_questionService.HasMoreGeneralQuestions(questionId))
            {
                // Переходим к следующему общему вопросу
                var nextQuestion = _questionService.GetNextGeneralQuestion(questionId);
                session.CurrentQuestionId = nextQuestion!.Id;
                _sessionService.UpdateSession(session);

                await ShowQuestion(chatId, session, botClient);
            }
            else
            {
                // Общие вопросы закончились - определяем лидирующий факультет
                var leadingFaculty = _resultService.GetLeadingFaculty(session.FacultyScores);
                session.LeadingFaculty = leadingFaculty;

                Console.WriteLine($"[HandleAnswer] Общие вопросы закончились. Лидер: {leadingFaculty}");

                // Получаем адаптивные вопросы для этого факультета
                var adaptiveQuestions = _questionService.GetAdaptiveQuestions(leadingFaculty);

                if (adaptiveQuestions.Count > 0)
                {
                    Console.WriteLine($"[HandleAnswer] Найдено {adaptiveQuestions.Count} адаптивных вопросов");

                    // Переходим к первому адаптивному вопросу
                    session.CurrentQuestionId = adaptiveQuestions[0].Id;
                    _sessionService.UpdateSession(session);

                    await ShowQuestion(chatId, session, botClient);
                }
                else
                {
                    Console.WriteLine("[HandleAnswer] Адаптивных вопросов нет, показываем результат");
                    await ShowResult(chatId, session, botClient);
                }
            }
        }
// Если это адаптивный вопрос
        else if (currentQuestion.Type == QuestionType.Adaptive)
        {
            var faculty = session.LeadingFaculty!;

            // Проверяем, есть ли ещё адаптивные вопросы для этого факультета
            if (_questionService.HasMoreAdaptiveQuestions(questionId, faculty))
            {
                // Переходим к следующему адаптивному вопросу
                var nextQuestion = _questionService.GetNextAdaptiveQuestion(questionId, faculty);
                session.CurrentQuestionId = nextQuestion!.Id;
                _sessionService.UpdateSession(session);

                await ShowQuestion(chatId, session, botClient);
            }
            else
            {
                // Адаптивные вопросы закончились - показываем результат
                Console.WriteLine("[HandleAnswer] Адаптивные вопросы закончились, показываем результат");
                await ShowResult(chatId, session, botClient);
            }
        }
    }
    
    // Показать результат теста
    private static async Task ShowResult(long chatId, UserSession session, ITelegramBotClient botClient)
    {
        Console.WriteLine("[ShowResult] Формируем результат");

        // Определяем лидирующий факультет
        var leadingFacultyCode = session.LeadingFaculty ?? _resultService.GetLeadingFaculty(session.FacultyScores);
        var leadingFaculty = FacultiesData.GetFacultyByCode(leadingFacultyCode);

        // Определяем лидирующее направление
        var leadingDirectionCode = _resultService.GetLeadingDirection(session.DirectionScores, leadingFacultyCode);
        var leadingDirection = FacultiesData.GetDirectionByCode(leadingDirectionCode);

        Console.WriteLine($"[ShowResult] Победитель: {leadingFacultyCode}");
        Console.WriteLine($"[ShowResult] Направление: {leadingDirectionCode}");
        Console.WriteLine(
            $"[ShowResult] Баллы направлений: {string.Join(", ", session.DirectionScores.Select(d => $"{d.Key}={d.Value}"))}");

        // Завершаем сессию
        _sessionService.EndSession(session.TelegramId);

        if (leadingFaculty == null)
        {
            await botClient.SendMessage(chatId, "❌ Ошибка при определении результата");
            return;
        }

        // Формируем основной текст результата
        var resultText = $"🎓 Результаты теста\n\n" +
                         $"✨ Тебе больше всего подходит:\n" +
                         $"{leadingFaculty.FullName}\n\n" +
                         $"📖 {leadingFaculty.Description}\n\n";

        // Добавляем рекомендуемое направление
        if (leadingDirection != null)
        {
            resultText += $"🎯 Рекомендуемое направление:\n" +
                          $"{leadingDirection.Name}\n\n";

            if (leadingDirection.Profiles.Count > 0)
            {
                resultText += "Профили:\n";
                foreach (var profile in leadingDirection.Profiles)
                {
                    resultText += $"  • {profile}\n";
                }

                resultText += "\n";
            }

            resultText += $"Что изучают: {leadingDirection.Description}\n\n";
            resultText += $"Кем можно работать: {leadingDirection.CareerProspects}\n\n";
        }
        else
        {
            Console.WriteLine("[ShowResult] ВНИМАНИЕ: Направление не определено!");
            resultText +=
                "⚠️ Не удалось определить конкретное направление. Рекомендуем изучить все направления факультета.\n\n";
        }

        // Топ-3 направления
        var topDirections = _resultService.GetTopDirections(session.DirectionScores, leadingFacultyCode, 3);

        if (topDirections.Count > 1)
        {
            resultText += "📚 Также тебе подойдут:\n";
            int count = 0;
            foreach (var (dirCode, score) in topDirections)
            {
                if (dirCode == leadingDirectionCode) continue; // Пропускаем главное

                var dir = FacultiesData.GetDirectionByCode(dirCode);
                if (dir != null)
                {
                    resultText += $"• {dir.Name}\n";
                    count++;
                    if (count >= 2) break; // Показываем только 2 дополнительных
                }
            }

            resultText += "\n";
        }

        resultText += "💡 Хочешь узнать больше о факультете? Нажми кнопку ниже!";

        // Кнопки
        var keyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData($"ℹ️ Подробнее о {leadingFaculty.ShortName}",
                    $"faculty_info_{leadingFacultyCode}")
            },
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
                  "• Анна Журкина\n" +
                  "• Артур Даминов",
            replyMarkup: keyboard
        );
    }

    // Показать детальную информацию о факультете
    private static async Task ShowFacultyInfo(long chatId, string facultyCode, ITelegramBotClient botClient)
    {
        var faculty = FacultiesData.GetFacultyByCode(facultyCode);

        if (faculty == null)
        {
            await botClient.SendMessage(chatId, "❌ Информация о факультете не найдена");
            return;
        }

        var infoText = $"🎓 {faculty.FullName}\n\n" +
                       $"📖 {faculty.Description}\n\n";

        // Направления
        if (faculty.Directions.Count > 0)
        {
            infoText += "📚 Направления подготовки:\n\n";

            foreach (var direction in faculty.Directions)
            {
                infoText += $"• {direction.Name}\n";

                if (direction.Profiles.Count > 0)
                {
                    infoText += "Профили:\n";
                    foreach (var profile in direction.Profiles)
                    {
                        infoText += $"  - {profile}\n";
                    }
                }

                infoText += $"Что изучают: {direction.Description}\n";
                infoText += $"Кем работать: {direction.CareerProspects}\n\n";
            }
        }

        // Контакты
        infoText += $"📞 Контакты:\n{faculty.ContactInfo}\n\n";
        infoText += $"🌐 Перейти на сайт: {faculty.WebsiteUrl}";

        var keyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("🔄 Пройти тест заново", "restart_test")
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("🏠 Главное меню", "main_menu")
            }
        });

        await botClient.SendMessage(
            chatId: chatId,
            text: infoText,
            replyMarkup: keyboard
        );
    }
}