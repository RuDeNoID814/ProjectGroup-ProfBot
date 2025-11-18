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
        return _allQuestions.FirstOrDefault( q => q.Id == questionId);
    }
    
    // получить первый общий вопрос
    public Question GetFirstQuestion()
    {
        return _allQuestions.First( q => q.Type == QuestionType.General);        
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
}