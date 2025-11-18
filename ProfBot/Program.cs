using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using ProjectGroup.handlers;

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
                Console.WriteLine($"Ошибка: {exception.Message}"); // Выводит исключение в консоль
            }
            
            // Метод для обработки сообщений:
            async Task OnMessage(Message msg, UpdateType type)
            {
                if (msg.Text == null) return;
                
                if (msg.Text == "/start")
                {
                    await CommandHandler.HandleStart(msg, bot);
                }
                else if (msg.Text == "/help")
                {
                    await CommandHandler.HandleHelp(msg, bot);
                }
            }
            
            // Метод, для обработки callback
            async Task OnUpdate(Update update)
            {
                if (update.CallbackQuery != null)
                {
                    await CallbackHandler.HandleCallback(update.CallbackQuery, bot);
                }
            }
        }
    }
}