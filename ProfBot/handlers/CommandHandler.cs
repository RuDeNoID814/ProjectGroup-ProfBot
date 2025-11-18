using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace ProjectGroup.handlers;

// Обработка команд

// обработка /start , /help
public class CommandHandler
{
    // /start
    public static async Task HandleStart(Message message, ITelegramBotClient botClient)
    {
        // клавиатура с кнопками
        var keyboard = new InlineKeyboardMarkup(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("🧪 Пройти тест", "start_test"),
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("ℹ️ О проекте", "about"),
            }
        });
        
        // приветственное сообщение
        await botClient.SendMessage(
            chatId: message.Chat.Id,
            text: "👋 Привет! Я бот для профориентации в ЧелГу.\n\n" +
                  " Я помогу тебе выбрать подходящий факультет на основе твоих интересов и навыков \n\n" +
                  "Нажми кнопку ниже, чтобы начать!",
            replyMarkup: keyboard
        );
    }
    
    // /help
    public static async Task HandleHelp(Message message, ITelegramBotClient botClient)
    {
        await botClient.SendMessage(
            chatId: message.Chat.Id,
            text: "ℹ️ Справка \n\n" +
                  "/start - Главное меню \n\n" +
                  "/help - Эта справка \n\n" +
                  "Бот задаст тебе несколько вопросов и порекомендует тебе подходящий факультет и направление"
        );
    }
}