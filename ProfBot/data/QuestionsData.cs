namespace ProjectGroup.data;

using ProjectGroup.models;

// Список вопросов
public static class QuestionsData
{
    public static List<Question> GetAllQuestions()
    {
        return new List<Question>
        {
            // Вопрос 1: Какой предмет тебе ближе всего?
            new Question
            {
                Id = 1,
                Text = "Какой предмет тебе ближе всего?",
                Type = QuestionType.General,
                ForFaculty = null,
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Text = "💻 Информатика, программирование",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 15 },
                            { "Math", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>() // пустой для общих вопросов
                    },
                    new Answer
                    {
                        Text = "🔢 Математика, решение задач",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Math", 15 },
                            { "IIT", 5 },
                            { "Physics", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>()
                    },
                    new Answer
                    {
                        Text = "⚛️ Физика, изучение природы",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Physics", 15 },
                            { "Math", 3 },
                            { "Chemistry", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>()
                    },
                    new Answer
                    {
                        Text = "🧪 Химия, эксперименты",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Chemistry", 15 },
                            { "Physics", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>()
                    },
                    new Answer
                    {
                        Text = "💰 Обществознание, экономика",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 15 }
                        },
                        DirectionScores = new Dictionary<string, int>()
                    },
                    new Answer
                    {
                        Text = "🤷 Затрудняюсь ответить",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 3 },
                            { "Math", 3 },
                            { "Physics", 3 },
                            { "Chemistry", 3 },
                            { "Economics", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>()
                    }
                }   
            }
        };
    }
}

// “IIT” – ИИТ
// “Math” - Математика
// “Physics” - Физика
// “Chemistry” - Химия
// “Economics” – Экономика
