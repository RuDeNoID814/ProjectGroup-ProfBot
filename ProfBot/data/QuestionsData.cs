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
                        DirectionScores = new Dictionary<string, int>()
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
            },

            // Вопрос 2: Какой формат работы тебе ближе?
            new Question
            {
                Id = 2,
                Text = "Какой формат работы тебе ближе?",
                Type = QuestionType.General,
                ForFaculty = null,
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Text = "💻 За компьютером, работать с программами",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 10 },
                            { "Physics", 5 },
                            { "Economics", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>()
                    },
                    new Answer
                    {
                        Text = "✏️ Решать задачи на бумаге, считать",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Math", 10 },
                            { "Physics", 5 },
                            { "Economics", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>()
                    },
                    new Answer
                    {
                        Text = "🔬  Работать с оборудованием, проводить эксперименты",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Physics", 10 },
                            { "Chemistry", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>()
                    },
                    new Answer
                    {
                        Text = "🧫 Проводить опыты",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Chemistry", 10 },
                            { "Physics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>()
                    },
                    new Answer
                    {
                        Text = "📊 Анализировать данные, строить графики",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 },
                            { "Math", 5 },
                            { "IIT", 3 }
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
            },

            // Вопрос 3: Что тебя больше вдохновляет?
            new Question
            {
                Id = 3,
                Text = "Что тебя больше вдохновляет?",
                Type = QuestionType.General,
                ForFaculty = null,
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Text = "🚀 Создавать приложения, сайты, игры",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 10 },
                            { "Math", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>()
                    },
                    new Answer
                    {
                        Text = "🧮 Доказывать теоремы, находить закономерности",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Math", 10 },
                            { "Physics", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>()
                    },
                    new Answer
                    {
                        Text = "⚡ Изучать законы природы (гравитация, электричество)",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Physics", 10 },
                            { "Math", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>()
                    },
                    new Answer
                    {
                        Text = "🧪 Открывать новые вещества и реакции",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Chemistry", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>()
                    },
                    new Answer
                    {
                        Text = "💼 Управлять проектами",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 }
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
            },

            // Вопрос 4: Что у тебя получается лучше всего?
            new Question
            {
                Id = 4,
                Text = "Что у тебя получается лучше всего?",
                Type = QuestionType.General,
                ForFaculty = null,
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Text = "💻 Работать с компьютером, быстро разбираться в программах",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 10 },
                            { "Math", 3 },
                            { "Economics", 2 }
                        },
                        DirectionScores = new Dictionary<string, int>()
                    },
                    new Answer
                    {
                        Text = "🧠 Решать сложные задачи, логически мыслить",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Math", 10 },
                            { "IIT", 3 },
                            { "Physics", 5 },
                        },
                        DirectionScores = new Dictionary<string, int>()
                    },
                    new Answer
                    {
                        Text = "🔧 Собирать и чинить вещи, работать руками",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Physics", 10 },
                            { "Chemistry", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>()
                    },
                    new Answer
                    {
                        Text = "🧪 Проводить опыты, наблюдать за процессами",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Chemistry", 10 },
                            { "Physics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>()
                    },
                    new Answer
                    {
                        Text = "🗣️ Общаться с людьми, договариваться, убеждать",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 }
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
            },

            // Вопрос 5: Где ты видишь себя через 5 лет?
            new Question
            {
                Id = 5,
                Text = "Где ты видишь себя через 5 лет?",
                Type = QuestionType.General,
                ForFaculty = null,
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Text = "🏢 В IT-компании, работаю над проектами",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 10 },
                            { "Math", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>()
                    },
                    new Answer
                    {
                        Text = "🎓 В университете, преподаю или занимаюсь наукой",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Math", 10 },
                            { "Physics", 5 },
                            { "IIT", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>()
                    },
                    new Answer
                    {
                        Text = "🔬 В научной лаборатории, провожу исследования",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Physics", 10 },
                            { "Chemistry", 5 },
                            { "Math", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>()
                    },
                    new Answer
                    {
                        Text = "🏭 На производстве, работаю с технологиями",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Physics", 10 },
                            { "Chemistry", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>()
                    },
                    new Answer
                    {
                        Text = "💼 В бизнесе, управляю проектами или компанией",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 },
                            { "IIT", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>()
                    },
                    new Answer
                    {
                        Text = "🏛️ В государственных структурах",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 },
                            { "Physics", 3 }
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
            },

            // АДАПТИВНЫЕ

            // ИИТ
            // 1 Вопрос
            new Question
            {
                Id = 6,
                Text = "Что тебе интереснее в программировании?",
                Type = QuestionType.Adaptive,
                ForFaculty = "IIT",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Text = "🌐 Создавать сайты, веб-приложения",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "IIT.AppliedInformatics", 15 },
                            { "IIT.BusinessInformatics", 5 }
                        }
                    },
                    new Answer
                    {
                        Text = "🤖 Работать с данными, AI, машинное обучение",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 5 },
                            { "Math", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "IIT.SoftwareEngineering_AI", 15 },
                            { "Math.AppliedMath", 5 }
                        }
                    },
                    new Answer
                    {
                        Text = "⚙️ Разрабатывать сложные системы, программное обеспечение",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "IIT.SoftwareEngineering_Systems", 15 },
                            { "IIT.SoftwareEngineering_AI", 5 }
                        }
                    },
                    new Answer
                    {
                        Text = "📊 Работать с бизнесом, аналитикой, финансами",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 5 },
                            { "Economics", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "IIT.BusinessInformatics", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🤷 Затрудняюсь ответить",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 2 },
                            { "Math", 2 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "IIT.AppliedInformatics", 2 },
                            { "IIT.BusinessInformatics", 2 },
                            { "IIT.SoftwareEngineering_Systems", 2 },
                            { "IIT.SoftwareEngineering_AI", 2 }
                        }
                    }
                }
            },
            // Вопрос 2
            new Question
            {
                Id = 7,
                Text = "Какой стиль работы тебе ближе?",
                Type = QuestionType.Adaptive,
                ForFaculty = "IIT",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Text = "👥 В команде, совместно решать задачи",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "IIT.SoftwareEngineering_Systems", 10 },
                            { "IIT.SoftwareEngineering_AI", 10 }
                        }
                    },
                    new Answer
                    {
                        Text = "🎨 Самостоятельно, создавать свои проекты ",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "IIT.AppliedInformatics", 10 }
                        }
                    },
                    new Answer
                    {
                        Text = "💼 Совмещать технологии и бизнес",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 5 },
                            { "Economics", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "IIT.BusinessInformatics", 10 }
                        }
                    },
                    new Answer
                    {
                        Text = "🔬 Исследовать, изучать новые технологии",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 3 },
                            { "Math", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Math.FundamentalCS", 10 }
                        }
                    },
                    new Answer
                    {
                        Text = "🤷 Затрудняюсь ответить",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 2 },
                            { "Math", 2 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "IIT.AppliedInformatics", 2 },
                            { "IIT.BusinessInformatics", 2 },
                            { "IIT.SoftwareEngineering_Systems", 2 },
                            { "IIT.SoftwareEngineering_AI", 2 }
                        }
                    }
                }
            },
            // Вопрос 3
            new Question
            {
                Id = 8,
                Text = "Что тебе важнее в работе?",
                Type = QuestionType.Adaptive,
                ForFaculty = "IIT",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Text = "🎨 Творчество, создавать что-то красивое и удобное",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "IIT.AppliedInformatics", 10 }
                        }
                    },
                    new Answer
                    {
                        Text = "🧠 Решать сложные технические задачи",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 5 },
                            { "Math", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "IIT.SoftwareEngineering_Systems", 10 },
                            { "IIT.SoftwareEngineering_AI", 10 }
                        }
                    },
                    new Answer
                    {
                        Text = "💰 Зарабатывать, работать с бизнесом",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 3 },
                            { "Economics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "IIT.BusinessInformatics", 10 }
                        }
                    },
                    new Answer
                    {
                        Text = "🔬 Исследовать, узнавать что-то новое",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 3 },
                            { "Math", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Math.FundamentalCS", 10 }
                        }
                    },
                    new Answer
                    {
                        Text = "🤷 Затрудняюсь ответить",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 2 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "IIT.AppliedInformatics", 2 },
                            { "IIT.BusinessInformatics", 2 },
                            { "IIT.SoftwareEngineering_Systems", 2 },
                            { "IIT.SoftwareEngineering_AI", 2 }
                        }
                    }
                }
            },
            // 4 Вопрос
            new Question
            {
                Id = 10,
                Text = "Какие технологии тебе интереснее?",
                Type = QuestionType.Adaptive,
                ForFaculty = "IIT",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Text = "🌐 Веб (сайты, интернет-сервисы)",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "IIT.AppliedInformatics", 10 }
                        }
                    },
                    new Answer
                    {
                        Text = "🤖 AI, нейросети, машинное обучение",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 5 },
                            { "Math", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "IIT.SoftwareEngineering_AI", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🔐 Кибербезопасность, защита данных",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 5 },
                            { "Math", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Math.ComputerSecurity", 10 }
                        }
                    },
                    new Answer
                    {
                        Text = "📱 Мобильные приложения (iOS, Android)",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "IIT.SoftwareEngineering_Systems", 10 },
                            { "IIT.SoftwareEngineering_AI", 10 }
                        }
                    },
                    new Answer
                    {
                        Text = "🤷 Затрудняюсь ответить",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "IIT", 2 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "IIT.AppliedInformatics", 2 },
                            { "IIT.BusinessInformatics", 2 },
                            { "IIT.SoftwareEngineering_Systems", 2 },
                            { "IIT.SoftwareEngineering_AI", 2 }
                        }
                    }
                }
            },


            // МАТЕМАТИКА
            // 1 Вопрос
            new Question
            {
                Id = 10,
                Text = "Теория или практика?",
                Type = QuestionType.Adaptive,
                ForFaculty = "Math",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Text = "📐 Чистая математика, доказательства теорем",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Math", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Math.MathAndCS", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "💻 Программирование + математика",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Math", 10 },
                            { "IIT", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Math.AppliedMath", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🔐 Криптография, безопасность",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Math", 10 },
                            { "IIT", 2 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Math.ComputerSecurity", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🔬 Фундаментальная информатика, исследования",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Math", 10 },
                            { "IIT", 2 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Math.FundamentalCS", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🤷 Затрудняюсь ответить",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Math", 2 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Math.MathAndCS", 2 },
                            { "Math.AppliedMath", 2 },
                            { "Math.ComputerSecurity", 2 },
                            { "Math.FundamentalCS", 2 }
                        }
                    }
                }
            },

            // Вопрос 2
            new Question
            {
                Id = 11,
                Text = "Где ты видишь себя?",
                Type = QuestionType.Adaptive,
                ForFaculty = "Math",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Text = "🎓 В университете, преподавать или заниматься наукой",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Math", 10 },
                            { "Physics", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Math.MathAndCS", 10 }
                        }
                    },
                    new Answer
                    {
                        Text = "💼 В IT-компании, анализировать данные",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Math", 5 },
                            { "IIT", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Math.AppliedMath", 10 }
                        }
                    },
                    new Answer
                    {
                        Text = "🔐 В кибербезопасности, защищать информацию",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Math", 5 },
                            { "IIT", 2 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Math.ComputerSecurity", 10 }
                        }
                    },
                    new Answer
                    {
                        Text = "🔬 В научной лаборатории",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Math", 10 },
                            { "Physics", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Math.FundamentalCS", 10 }
                        }
                    },
                    new Answer
                    {
                        Text = "🤷 Затрудняюсь ответить",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Math", 2 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Math.MathAndCS", 2 },
                            { "Math.AppliedMath", 2 },
                            { "Math.ComputerSecurity", 2 },
                            { "Math.FundamentalCS", 2 }
                        }
                    }
                }
            },


            // ФИЗИКА
            // 1 Вопрос
            new Question
            {
                Id = 12,
                Text = "Теория или эксперименты?",
                Type = QuestionType.Adaptive,
                ForFaculty = "Physics",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Text = "📚 Теоретическая физика, решать уравнения",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Physics", 10 },
                            { "Math", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Physics.Physics", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🔬 Экспериментальная физика, работать с оборудованием",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Physics", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Physics.Physics", 10 },
                            { "Physics.Radiophysics", 5 }
                        }
                    },
                    new Answer
                    {
                        Text = "📡 Радиофизика, электроника, связь",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Physics", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Physics.Radiophysics", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🔩 Материаловедение, изучать свойства материалов",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Physics", 10 },
                            { "Chemistry", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Physics.Materials", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🤷 Затрудняюсь ответить",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Physics", 2 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Physics.Physics", 2 },
                            { "Physics.Radiophysics", 2 },
                            { "Physics.Ballistics", 2 },
                            { "Physics.Nanoengineering", 2 },
                            { "Physics.Materials", 2 }
                        }
                    }
                }
            },
            // 2 Вопрос
            new Question
            {
                Id = 13,
                Text = "Какая область физики интереснее?",
                Type = QuestionType.Adaptive,
                ForFaculty = "Physics",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Text = "⚡ Электричество, магнетизм",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Physics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Physics.Radiophysics", 10 },
                            { "Physics.Physics", 5 }
                        }
                    },
                    new Answer
                    {
                        Text = "⚛️ Ядерная физика, квантовая механика",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Physics", 5 },
                            { "Math", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Physics.Physics", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🚀 Механика, баллистика, аэродинамика",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Physics", 5 },
                            { "Math", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Physics.Ballistics", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🔬 Нанотехнологии, новые материалы",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Physics", 5 },
                            { "Chemistry", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Physics.Nanoengineering", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🤷 Затрудняюсь ответить",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Physics", 2 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Physics.Physics", 2 },
                            { "Physics.Radiophysics", 2 },
                            { "Physics.Ballistics", 2 },
                            { "Physics.Nanoengineering", 2 },
                            { "Physics.Materials", 2 }
                        }
                    }
                }
            },

            // ХИМИЯ
            // 1 Вопрос
            new Question
            {
                Id = 14,
                Text = "Что тебе ближе в химии?",
                Type = QuestionType.Adaptive,
                ForFaculty = "Chemistry",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Text = "🧪 Аналитическая химия, анализировать состав веществ",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Chemistry", 15 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Chemistry.Chemistry", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "⚗️ Органическая химия, синтез новых веществ",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Chemistry", 15 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Chemistry.Chemistry", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🔬 Физическая химия, изучать процессы",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Chemistry", 10 },
                            { "Physics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Chemistry.Chemistry", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🏭 Промышленная химия, производство",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Chemistry", 10 },
                            { "Physics", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Chemistry.Chemistry", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🤷 Затрудняюсь ответить",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Chemistry", 5 },
                            { "Physics", 2 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Chemistry.Chemistry", 5 }
                        }
                    }
                }
            },

            // ЭКОНОМИКА
            // 1 Вопрос
            new Question
            {
                Id = 15,
                Text = "Что тебе ближе в экономике?",
                Type = QuestionType.Adaptive,
                ForFaculty = "Economics",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Text = "💰 Финансы, деньги, инвестиции, аудит",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 15 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Economics", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "📊 Управление бизнесом, развитие компании",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Management", 15 },
                            { "Economics.Economics", 5 }
                        }
                    },
                    new Answer
                    {
                        Text = "🎓 Преподавание и обучение экономике",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.PedagogicalEducation", 15 },
                            { "Economics.Sociology", 3 }
                        }
                    },
                    new Answer
                    {
                        Text = "💡 Инновации, внедрять новые идеи в бизнес",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Innovation", 15 },
                            { "Economics.Management", 5 }
                        }
                    },
                    new Answer
                    {
                        Text = "📈 Анализ рынка и общества",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Sociology", 15 },
                            { "Economics.Economics", 5 }
                        }
                    },
                    new Answer
                    {
                        Text = "🤝 Социальная помощь и работа с людьми",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.SocialWork", 15 },
                            { "Economics.HRM", 5 }
                        }
                    },
                    new Answer
                    {
                        Text = "🏛️ Государственное управление, работать в госструктурах",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.PublicAdministration", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "👥 Управление персоналом, работа с людьми в компаниях",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.HRM", 15 },
                            { "Economics.Management", 5 }
                        }
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
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Economics", 2 },
                            { "Economics.Management", 2 },
                            { "Economics.PublicAdministration", 2 },
                            { "Economics.PedagogicalEducation", 2 },
                            { "Economics.Innovation", 2 },
                            { "Economics.Sociology", 2 },
                            { "Economics.SocialWork", 2 },
                            { "Economics.HRM", 2 }
                        }
                    }
                }
            },
            // 2 Вопрос
            new Question
            {
                Id = 16,
                Text = "С кем тебе интереснее работать?",
                Type = QuestionType.Adaptive,
                ForFaculty = "Economics",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Text = "💼 С бизнесом, компаниями и предпринимателями",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Management", 10 },
                            { "Economics.Economics", 10 }
                        }
                    },
                    new Answer
                    {
                        Text = "🏛️ С государственными структурами",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.PublicAdministration", 15 },
                            { "Economics.Management", 5 }
                        }
                    },
                    new Answer
                    {
                        Text = "🎓 Со студентами и школьниками (обучение)",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.PedagogicalEducation", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🚀 С инновационными проектами и стартапами",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Innovation", 15 },
                            { "Economics.Management", 5 }
                        }
                    },
                    new Answer
                    {
                        Text = "📊 С исследователями и аналитиками",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 },
                            { "Math", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Sociology", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🤝 С людьми, которым нужна помощь",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 },
                            { "Physics", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.SocialWork", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "👥 С персоналом компаний (HR)",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.HRM", 15 },
                            { "Economics.Management", 5 }
                        }
                    },
                    new Answer
                    {
                        Text = "💰 Со всеми, кто платит",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Management", 10 },
                            { "Economics.Economics", 5 }
                        }
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
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Economics", 2 },
                            { "Economics.Management", 2 },
                            { "Economics.PublicAdministration", 2 },
                            { "Economics.PedagogicalEducation", 2 },
                            { "Economics.Innovation", 2 },
                            { "Economics.Sociology", 2 },
                            { "Economics.SocialWork", 2 },
                            { "Economics.HRM", 2 }
                        }
                    }
                }
            },
            // 3 Вопрос
            new Question
            {
                Id = 17,
                Text = "Что тебе интереснее?",
                Type = QuestionType.Adaptive,
                ForFaculty = "Economics",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Text = "💸 Считать деньги, анализировать бюджеты",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Economics", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "📈 Развивать бизнес, управлять проектами",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 },
                            { "IIT", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Management", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "📚 Объяснять сложные вещи простыми словами",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.PedagogicalEducation", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "💡 Придумывать новые бизнес-модели",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Innovation", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🔍 Проводить опросы, изучать мнение людей",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Sociology", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🤝 Помогать людям в трудных ситуациях",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.SocialWork", 10 },
                            { "Economics.HRM", 5 }
                        }
                    },
                    new Answer
                    {
                        Text = "📜 Работать с документами и законами",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.PublicAdministration", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "👥 Проводить собеседования, нанимать людей",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.HRM", 15 }
                        }
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
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Economics", 2 },
                            { "Economics.Management", 2 },
                            { "Economics.PublicAdministration", 2 },
                            { "Economics.PedagogicalEducation", 2 },
                            { "Economics.Innovation", 2 },
                            { "Economics.Sociology", 2 },
                            { "Economics.SocialWork", 2 },
                            { "Economics.HRM", 2 }
                        }
                    }
                }
            },
            // 4 Вопрос
            new Question
            {
                Id = 18,
                Text = "Работа с людьми или с данными?",
                Type = QuestionType.Adaptive,
                ForFaculty = "Economics",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Text = "💻 С данными, цифрами и отчётами",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 },
                            { "Math", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Economics", 10 },
                            { "Economics.Sociology", 5 }
                        }
                    },
                    new Answer
                    {
                        Text = "🗣️ С людьми, управлять командой",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 },
                            { "IIT", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Management", 10 },
                            { "Economics.HRM", 5 }
                        }
                    },
                    new Answer
                    {
                        Text = "🎓 Учить людей, передавать знания",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.PedagogicalEducation", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "💡 Комбинировать: данные + творчество",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Innovation", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "📊 Исследовать рынок через данные и общение",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 },
                            { "Math", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Sociology", 15 },
                            { "Economics.Economics", 5 }
                        }
                    },
                    new Answer
                    {
                        Text = "🤝 Помогать людям, общаться с ними",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.SocialWork", 10 },
                            { "Economics.HRM", 5 }
                        }
                    },
                    new Answer
                    {
                        Text = "📜 С документами и законами",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.PublicAdministration", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "👥 Развивать сотрудников, работать в HR",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.HRM", 15 },
                            { "Economics.Management", 5 }
                        }
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
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Economics", 2 },
                            { "Economics.Management", 2 },
                            { "Economics.PublicAdministration", 2 },
                            { "Economics.PedagogicalEducation", 2 },
                            { "Economics.Innovation", 2 },
                            { "Economics.Sociology", 2 },
                            { "Economics.SocialWork", 2 },
                            { "Economics.HRM", 2 }
                        }
                    }
                }
            },
            // 5 Вопрос
            new Question
            {
                Id = 19,
                Text = "Что важнее в работе?",
                Type = QuestionType.Adaptive,
                ForFaculty = "Economics",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Text = "💰 Зарабатывать и расти в карьере",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Economics", 10 },
                            { "Economics.Management", 5 }
                        }
                    },
                    new Answer
                    {
                        Text = "📊 Управлять и принимать решения",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Management", 10 },
                            { "Economics.PublicAdministration", 5 }
                        }
                    },
                    new Answer
                    {
                        Text = "🎓 Обучать и делиться знаниями",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.PedagogicalEducation", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🚀 Внедрять инновации, быть первопроходцем",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Innovation", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🔍 Изучать, исследовать, узнавать новое",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 },
                            { "Math", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Sociology", 15 },
                            { "Economics.Economics", 5 }
                        }
                    },
                    new Answer
                    {
                        Text = "🤝 Помогать обществу, делать мир лучше",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.SocialWork", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🏛️ Работать на благо города и государства",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.PublicAdministration", 10 }
                        }
                    },
                    new Answer
                    {
                        Text = "👥 Развивать людей и помогать им расти",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.HRM", 15 },
                            { "Economics.Management", 5 }
                        }
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
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Economics", 2 },
                            { "Economics.Management", 2 },
                            { "Economics.PublicAdministration", 2 },
                            { "Economics.PedagogicalEducation", 2 },
                            { "Economics.Innovation", 2 },
                            { "Economics.Sociology", 2 },
                            { "Economics.SocialWork", 2 },
                            { "Economics.HRM", 2 }
                        }
                    }
                }
            },
            // 6 Вопрос
            new Question
            {
                Id = 20,
                Text = "Какие навыки тебе ближе?",
                Type = QuestionType.Adaptive,
                ForFaculty = "Economics",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Text = "🧮 Финансовый анализ, работа с цифрами",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 },
                            { "Math", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Economics", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "📈 Стратегия, планирование, управление",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Management", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "🗣️ Коммуникация, обучение, объяснение",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.PedagogicalEducation", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "💡 Креативность, новые идеи",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Innovation", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "📊 Исследования, анализ данных, опросы",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 },
                            { "Math", 3 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Sociology", 15 },
                            { "Economics.Economics", 5 }
                        }
                    },
                    new Answer
                    {
                        Text = "❤️ Эмпатия, помощь людям",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.SocialWork", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "📜 Законы, нормативы, документы",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 5 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.PublicAdministration", 15 }
                        }
                    },
                    new Answer
                    {
                        Text = "👥 Работа с людьми, мотивация, развитие (HR)",
                        FacultyScores = new Dictionary<string, int>
                        {
                            { "Economics", 10 }
                        },
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.HRM", 15 },
                            { "Economics.Management", 5 }
                        }
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
                        DirectionScores = new Dictionary<string, int>
                        {
                            { "Economics.Economics", 2 },
                            { "Economics.Management", 2 },
                            { "Economics.PublicAdministration", 2 },
                            { "Economics.PedagogicalEducation", 2 },
                            { "Economics.Innovation", 2 },
                            { "Economics.Sociology", 2 },
                            { "Economics.SocialWork", 2 },
                            { "Economics.HRM", 2 }
                        }
                    }
                }
            }
        };
    }
}

// Для адаптивных вопросов:
//     •	Основное направление: +15
//     •	Сильное направление: +10
//     •	Связанное направление: +5
//     •	Факультету (доп. баллы): +5 или +3
//     •	Другим факультетам (камбэк): +3 или +5
//     •	Затрудняюсь: +2 (всем)
// Правильные ключи факультетов:
//     “IIT” – ИИТ
//     “Math” - Математика
//     “Physics” - Физика
//     “Chemistry” - Химия
//     “Economics” – Экономика

//     Ключи для направлений:
// IIT.AppliedInformatics          // Прикладная информатика
// IIT.BusinessInformatics         // Бизнес-информатика
// IIT.SoftwareEngineering_Systems // Программная инженерия (Разработка ПО систем)
// IIT.SoftwareEngineering_AI      // Программная инженерия (Интеллектуальные системы)
//     .
// Math.MathAndCS           // Математика и компьютерные науки
// Math.AppliedMath         // Прикладная математика и информатика
// Math.ComputerSecurity    // Компьютерная безопасность
// Math.FundamentalCS       // Фундаментальная информатика и информационные технологии
//     .
// Physics.Physics          // Физика
// Physics.Radiophysics     // Радиофизика
// Physics.Ballistics       // Баллистика и гидроаэродинамика
// Physics.Nanoengineering  // Наноинженерия
// Physics.Materials        // Материаловедение и технологии материалов
//     .
// Chemistry.Chemistry      // Химия (профиль: Аналитическая химия и химическая экспертиза)
//     .
// Economics.Economics              // Экономика
// Economics.Management             // Менеджмент
// Economics.PublicAdministration   // Государственное и муниципальное управление
// Economics.PedagogicalEducation   // Педагогическое образование
// Economics.Innovation             // Инноватика
// Economics.Sociology              // Социология
// Economics.SocialWork             // Социальная работа
// Economics.HRM                    // Управление персоналом