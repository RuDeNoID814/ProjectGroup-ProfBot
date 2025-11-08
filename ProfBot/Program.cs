using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace ProjectGroup
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var cts = new CancellationTokenSource();
            var bot = new TelegramBotClient("8513376714:AAHrY4ydxyT3blfPaxCtHOAwZwjUY8ecW8w", cancellationToken: cts.Token);
            var me = await bot.GetMe();
            bot.OnError += OnError;
            bot.OnMessage += OnMessage;
            bot.OnUpdate += OnUpdate;
            
            Console.WriteLine($"@{me.Username} запущен... Нажмите Enter для завершения");
            Console.ReadLine();
            cts.Cancel(); // Бот остановится

            // Метод обработки ошибок
            async Task OnError(Exception exception, HandleErrorSource source)
            {
                Console.WriteLine(exception); // Выводит исключение в консоль
            }
            
            // Метод для обработки сообщений:
            async Task OnMessage(Message msg, UpdateType type)
            {
                if (msg.Text == "/start")
                {
                    await bot.SendMessage(msg.Chat, "Приветствую! Выбери что-то", replyMarkup: new InlineKeyboardButton[] {"Левая кнопка", "Правая кнопка"});
                }
            }
            
            // Метод, который обрабатывает другие типы обновлений, получаемых ботом
            async Task OnUpdate(Update update)
            {
                if (update is { CallbackQuery: { } query }) // Нулевой запрос обратного вызова
                {
                    await bot.AnswerCallbackQuery(query.Id, $"Ты выбрал {query.Data}");
                    await bot.SendMessage(query.Message!.Chat, $"Пользователь {query.From} кликнул на {query.Data}");
                }
            }
        }
    }
}