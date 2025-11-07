using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace ProjectGroup
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var cts = new CancellationTokenSource();
            var bot = new TelegramBotClient("8513376714:AAHrY4ydxyT3blfPaxCtHOAwZwjUY8ecW8w", cancellationToken: cts.Token);
            var me = await bot.GetMe();
            bot.OnMessage += OnMessage;
            
            Console.WriteLine($"@{me.Username} запущен... Нажмите Enter для завершения");
            Console.ReadLine();
            cts.Cancel(); // Бот остановится
            
            // Метод для обработки сообщений:
            async Task OnMessage(Message msg, UpdateType type)
            {
                if (msg.Text is null) return; // Обработка только текстовых сообщений
                Console.WriteLine($"Получено {type} '{msg.Text}' в {msg.Chat}");
                // Повторяем полученное сообщение
                await bot.SendMessage(msg.Chat, $"{msg.From} сказал: {msg.Text}");
            }
        }
    }
}