namespace ProjectGroup.models;

public enum QuestionType
{
    General, // Общий вопрос (все проходят) 
    Adaptive // Адаптивный (зависит от лидирующего факультета)
}


// Модели вопросов
public class Question
{
    public int Id { get; set; } // Номер вопроса
    public string Text { get; set; } = string.Empty; // Текст вопроса
    public QuestionType Type { get; set; } // Для адаптивных вопросов - какому факультету принадлежит
    public string? ForFaculty { get; set; } // null для General (string? - может быть Null)
                                            // (то есть, когда мы будем делать "общий" вопрос,
                                            // то мы можем поставить Null и
                                            // он не будет привязан ни к какому факультету)
    public List<Answer> Answers { get; set; } = new(); // Варианты ответов
}

public class Answer
{
    public string Text { get; set; } = string.Empty;
    public Dictionary<string, int> FacultyScores { get; set; } = new(); // Баллы для факультетов
    public Dictionary<string, int> DirectionScores { get; set; } = new(); // Баллы для направлений
}