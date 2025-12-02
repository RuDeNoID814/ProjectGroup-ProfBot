namespace ProjectGroup.services;

using ProjectGroup.models;
using ProjectGroup.data;

// Логика работы с вопросами

public class QuestionService
{
    private readonly List<Question> _allQuestions;

    public QuestionService()
    {
        _allQuestions = QuestionsData.GetAllQuestions();
    }

    // получить вопрос по id
    public Question? GetQuestionById(int questionId)
    {
        return _allQuestions.FirstOrDefault(q => q.Id == questionId);
    }

    // получить первый общий вопрос
    public Question GetFirstQuestion()
    {
        return _allQuestions.First(q => q.Type == QuestionType.General);
    }

    // получить следующий общий вопрос
    public Question? GetNextGeneralQuestion(int currentQuestionId)
    {
        return _allQuestions.FirstOrDefault(q =>
            q.Type == QuestionType.General &&
            q.Id > currentQuestionId);
    }

    // проверить, есть ли еще общие вопросы
    public bool HasMoreGeneralQuestions(int currentQuestionId)
    {
        return _allQuestions.Any(q =>
            q.Type == QuestionType.General &&
            q.Id > currentQuestionId);
    }

    // Получить адаптивные вопросы для факультета
    public List<Question> GetAdaptiveQuestions(string faculty)
    {
        return _allQuestions
            .Where(q => q.Type == QuestionType.Adaptive && q.ForFaculty == faculty)
            .OrderBy(q => q.Id)
            .ToList();
    }

    // Получить следующий адаптивный вопрос для факультета
    public Question? GetNextAdaptiveQuestion(int currentQuestionId, string faculty)
    {
        return _allQuestions.FirstOrDefault(q =>
            q.Type == QuestionType.Adaptive &&
            q.ForFaculty == faculty &&
            q.Id > currentQuestionId);
    }

    // Проверить, есть ли ещё адаптивные вопросы для факультета
    public bool HasMoreAdaptiveQuestions(int currentQuestionId, string faculty)
    {
        return _allQuestions.Any(q =>
            q.Type == QuestionType.Adaptive &&
            q.ForFaculty == faculty &&
            q.Id > currentQuestionId);
    }
}