namespace ProjectGroup.models;

// Хранение прогресса во время теста
public class UserSession
{
    public long TelegramId { get; set; }
    
    public int CurrentQuestionId { get; set; } // на каком вопросе сейчас
    
    public bool IsTestActive { get; set; } // true или false
    
    public DateTime StartedAt { get; set; } // когда начал тест
    
    public Dictionary<string, int> FacultyScores { get; set; } = new(); // баллы по факультетам
    // IIT, Math, Physics, Chemistry, Economics
    
    public Dictionary<string, int> DirectionScores { get; set; } = new(); // баллы по наравлениям
    
    public List<int> AnsweredQuestions { get; set; } = new(); // История вопросов
    
    public string? LeadingFaculty { get; set; } // Лидирующий факультет
}