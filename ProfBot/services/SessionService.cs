namespace ProjectGroup.services;

using ProjectGroup.models;

// Логика сессия пользователя
public class SessionService
{
    // хранилище сессий в памяти (ключ = TelegramId)
    private Dictionary<long, UserSession> _sessions = new();

    public UserSession CreateSession(long telegramId)
    {
        Console.WriteLine($"[SessionService] Создаём сессию для {telegramId}");
        var session = new UserSession()
        {
            TelegramId = telegramId,
            CurrentQuestionId = 1, // начинаем с 1 вопроса
            IsTestActive = true,
            StartedAt = DateTime.Now,
            FacultyScores = new Dictionary<string, int>
            {
                { "IIT", 0 },
                { "Math", 0 },
                { "Physics", 0 },
                { "Chemistry", 0 },
                { "Economics", 0 },

            },
            DirectionScores = new Dictionary<string, int>(),
            AnsweredQuestions = new List<int>(),
            LeadingFaculty = null
        };
        // сохраняем в словарь
        _sessions[telegramId] = session;
        
        Console.WriteLine($"[SessionService] Сессия создана. CurrentQuestionId = {session.CurrentQuestionId}");
        return session;
    }
    
    // получить сессию пользователя (или null, если нет)
    public UserSession? GetSession(long telegramId)
    {
        // проверяем есть ли в словаре
        if (_sessions.ContainsKey(telegramId))
        {
            return _sessions[telegramId];  
        }
        return null;
    }
    
    // проверить, есть ли у пользователя активная сессия
    public bool HasActiveSession(long telegramId)
    {
        // Проверяем 2 условия
        // 1. Сессия существует
        // 2. Сессия активна
        return _sessions.ContainsKey(telegramId) && _sessions[telegramId].IsTestActive;
    }

    // Обновить сессию (после ответа на вопрос)
    public void UpdateSession(UserSession session)
    {
        _sessions[session.TelegramId] = session;
        Console.WriteLine($"[SessionService] Сессия обновлена. CurrentQuestionId = {session.CurrentQuestionId}");
    }
    
    // Завершить сессию
    public void EndSession(long telegramId)
    {
        if (_sessions.ContainsKey(telegramId))
        {
            _sessions[telegramId].IsTestActive = false;
            Console.WriteLine($"[SessionService] Сессия {telegramId} завершена");
        }
    }
    
    // Удалить сессию (если нужно начать заново)
    public void DeleteSession(long telegramId)
    {
        if (_sessions.ContainsKey(telegramId))
        {
            _sessions.Remove(telegramId);
        }
    }
}