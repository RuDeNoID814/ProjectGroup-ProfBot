using ProjectGroup.models;

namespace ProjectGroup.data;

// База данных факультетов и направлений ЧелГУ
public static class FacultiesData
{
    public static List<Faculty> GetAllFaculties()
    {
        return new List<Faculty>
        {
            // ИИТ
            new Faculty
            {
                Code = "IIT",
                ShortName = "ИИТ",
                FullName = "Институт информационных технологий",
                Description = "Готовим специалистов в области IT: программистов, разработчиков, аналитиков данных и специалистов по информационной безопасности.",
                WebsiteUrl = "https://www.csu.ru/Lists/List2/страница%20факультета.aspx?ID=25",
                ContactInfo = "Телефон: +7 (351) 799-72-80\nEmail: iit@csu.ru\nГрафик работы: пн-чт: с 8:00 до\n17:30, пт: с 8:00 до 16:00",
                Directions = new List<Direction>
                {
                    new Direction
                    {
                        Code = "IIT.AppliedInformatics",
                        Name = "Прикладная информатика",
                        FacultyCode = "IIT",
                        Profiles = new List<string>
                        {
                            "Прикладная информатика в экономике",
                            "Прикладная информатика в управлении"
                        },
                        Description = "Изучение разработки информационных систем, баз данных, веб-приложений и мобильных приложений для бизнеса.",
                        CareerProspects = "Веб-разработчик, системный аналитик, разработчик мобильных приложений, IT-консультант"
                    },
                    new Direction
                    {
                        Code = "IIT.BusinessInformatics",
                        Name = "Бизнес-информатика",
                        FacultyCode = "IIT",
                        Profiles = new List<string>
                        {
                            "Электронный бизнес",
                            "Архитектура предприятия"
                        },
                        Description = "Сочетание IT и бизнеса: автоматизация бизнес-процессов, управление IT-проектами, электронная коммерция.",
                        CareerProspects = "Бизнес-аналитик, IT-менеджер, специалист по электронной коммерции, консультант по цифровой трансформации"
                    },
                    new Direction
                    {
                        Code = "IIT.SoftwareEngineering_Systems",
                        Name = "Программная инженерия (Разработка ПО систем)",
                        FacultyCode = "IIT",
                        Profiles = new List<string>
                        {
                            "Разработка программно-информационных систем"
                        },
                        Description = "Разработка сложных программных систем, архитектура ПО, тестирование и сопровождение.",
                        CareerProspects = "Инженер-программист, архитектор ПО, team lead, DevOps-инженер"
                    },
                    new Direction
                    {
                        Code = "IIT.SoftwareEngineering_AI",
                        Name = "Программная инженерия (Интеллектуальные системы)",
                        FacultyCode = "IIT",
                        Profiles = new List<string>
                        {
                            "Инженерия информационных и интеллектуальных систем"
                        },
                        Description = "Разработка систем искусственного интеллекта, машинное обучение, нейронные сети, обработка больших данных.",
                        CareerProspects = "ML-инженер, Data Scientist, AI-разработчик, исследователь в области ИИ"
                    }
                }
            },
            
            // МАТЕМАТИЧЕСКИЙ ФАКУЛЬТЕТ
            new Faculty
            {
                Code = "Math",
                ShortName = "Матфак",
                FullName = "Математический факультет",
                Description = "Готовим математиков, программистов и специалистов по информационной безопасности с фундаментальной подготовкой.",
                WebsiteUrl = "https://www.csu.ru/Lists/List2/страница%20факультета.aspx?ID=2",
                ContactInfo = "Телефон: +7 (351) 799-71-18\nEmail: math_faculty@csu.ru\nГрафик работы: пн-пт: с 8:00 до 17:00",
                Directions = new List<Direction>
                {
                    new Direction
                    {
                        Code = "Math.MathAndCS",
                        Name = "Математика и компьютерные науки",
                        FacultyCode = "Math",
                        Profiles = new List<string>
                        {
                            "Математика и компьютерные науки"
                        },
                        Description = "Фундаментальная математика + программирование: алгоритмы, дискретная математика, теория вычислений.",
                        CareerProspects = "Математик-программист, научный сотрудник, преподаватель, разработчик алгоритмов"
                    },
                    new Direction
                    {
                        Code = "Math.AppliedMath",
                        Name = "Прикладная математика и информатика",
                        FacultyCode = "Math",
                        Profiles = new List<string>
                        {
                            "Математическое моделирование",
                            "Анализ данных"
                        },
                        Description = "Применение математики для решения практических задач: моделирование, анализ данных, оптимизация.",
                        CareerProspects = "Data Analyst, аналитик данных, специалист по математическому моделированию, исследователь"
                    },
                    new Direction
                    {
                        Code = "Math.ComputerSecurity",
                        Name = "Компьютерная безопасность",
                        FacultyCode = "Math",
                        Profiles = new List<string>
                        {
                            "Математические методы защиты информации"
                        },
                        Description = "Криптография, защита информации, информационная безопасность с упором на математику.",
                        CareerProspects = "Специалист по информационной безопасности, криптограф, аналитик угроз, пентестер"
                    },
                    new Direction
                    {
                        Code = "Math.FundamentalCS",
                        Name = "Фундаментальная информатика и информационные технологии",
                        FacultyCode = "Math",
                        Profiles = new List<string>
                        {
                            "Фундаментальная информатика"
                        },
                        Description = "Теоретическая информатика, теория алгоритмов, формальные языки, искусственный интеллект.",
                        CareerProspects = "Исследователь в области CS, разработчик сложных алгоритмов, научный сотрудник"
                    }
                }
            },
            
            // ФИЗИЧЕСКИЙ ФАКУЛЬТЕТ
            new Faculty
            {
                Code = "Physics",
                ShortName = "Физфак",
                FullName = "Физический факультет",
                Description = "Готовим физиков-исследователей, инженеров и специалистов в области нанотехнологий и материаловедения.",
                WebsiteUrl = "https://www.csu.ru/Lists/List2/страница%20факультета.aspx?ID=16",
                ContactInfo = "Телефон: +7 (351) 799-71-19\nEmail: phys_faculty@csu.ru\nГрафик работы: пн-чт: с 8:30 до 11:00 и 14:00 до 16:00\nпт: с 8:30 до 11:00",
                Directions = new List<Direction>
                {
                    new Direction
                    {
                        Code = "Physics.Physics",
                        Name = "Физика",
                        FacultyCode = "Physics",
                        Profiles = new List<string>
                        {
                            "Фундаментальная физика",
                            "Физика конденсированного состояния"
                        },
                        Description = "Теоретическая и экспериментальная физика, квантовая механика, физика твёрдого тела.",
                        CareerProspects = "Физик-исследователь, научный сотрудник, инженер-физик, преподаватель"
                    },
                    new Direction
                    {
                        Code = "Physics.Radiophysics",
                        Name = "Радиофизика",
                        FacultyCode = "Physics",
                        Profiles = new List<string>
                        {
                            "Электроника и наноэлектроника",
                            "Квантовая электроника"
                        },
                        Description = "Электроника, радиотехника, телекоммуникации, радиоэлектронные системы.",
                        CareerProspects = "Инженер-электронщик, разработчик радиоэлектронной аппаратуры, специалист по телекоммуникациям"
                    },
                    new Direction
                    {
                        Code = "Physics.Ballistics",
                        Name = "Баллистика и гидроаэродинамика",
                        FacultyCode = "Physics",
                        Profiles = new List<string>
                        {
                            "Баллистика",
                            "Гидроаэродинамика"
                        },
                        Description = "Механика, аэродинамика, баллистика, моделирование движения тел.",
                        CareerProspects = "Инженер-баллистик, специалист по аэродинамике, научный сотрудник"
                    },
                    new Direction
                    {
                        Code = "Physics.Nanoengineering",
                        Name = "Наноинженерия",
                        FacultyCode = "Physics",
                        Profiles = new List<string>
                        {
                            "Нанотехнологии и наноматериалы"
                        },
                        Description = "Нанотехнологии, наноматериалы, микроэлектроника, физика наноструктур.",
                        CareerProspects = "Инженер-нанотехнолог, разработчик наноматериалов, специалист по микроэлектронике"
                    },
                    new Direction
                    {
                        Code = "Physics.Materials",
                        Name = "Материаловедение и технологии материалов",
                        FacultyCode = "Physics",
                        Profiles = new List<string>
                        {
                            "Материаловедение",
                            "Технологии новых материалов"
                        },
                        Description = "Изучение свойств материалов, разработка новых материалов, технологии производства.",
                        CareerProspects = "Инженер-материаловед, технолог, специалист по контролю качества материалов"
                    }
                }
            },


            // ХИМИЧЕСКИЙ ФАКУЛЬТЕТ
            new Faculty
            {
                Code = "Chemistry",
                ShortName = "Химфак",
                FullName = "Химический факультет",
                Description = "Готовим химиков-аналитиков, технологов и специалистов по химической экспертизе.",
                WebsiteUrl = "https://www.csu.ru/Lists/List2/страница%20факультета.aspx?ID=18",
                ContactInfo = "Телефон: +7 (351) 799-70-63\nEmail: chem_faculty@csu.ru",
                Directions = new List<Direction>
                {
                    new Direction
                    {
                        Code = "Chemistry.Chemistry",
                        Name = "Химия",
                        FacultyCode = "Chemistry",
                        Profiles = new List<string>
                        {
                            "Аналитическая химия и химическая экспертиза"
                        },
                        Description = "Аналитическая химия, физическая химия, органическая химия, химическая экспертиза, контроль качества.",
                        CareerProspects = "Химик-аналитик, эксперт-криминалист, технолог, специалист по контролю качества, лаборант"
                    }
                }
            },


            // ФАКУЛЬТЕТ ЭКОНОМИКИ И УПРАВЛЕНИЯ
            new Faculty
            {
                Code = "Economics",
                ShortName = "ФЭУ",
                FullName = "Факультет экономики и управления",
                Description = "Готовим экономистов, менеджеров, специалистов по государственному управлению и социальной работе.",
                WebsiteUrl = "https://www.csu.ru/Lists/List2/страница%20факультета.aspx?ID=11",
                ContactInfo = "Телефон: +7 (351) 799-70-74\nEmail: han@csu.ru\nГрафик работы: пн-чт: с 8:00 до 17:00\nпт: с 8:00 до 15:45\nобед: с 12:00 до 12:45",
                Directions = new List<Direction>
                {
                    new Direction
                    {
                        Code = "Economics.Economics",
                        Name = "Экономика",
                        FacultyCode = "Economics",
                        Profiles = new List<string>
                        {
                            "Финансы и кредит",
                            "Бухгалтерский учёт и аудит",
                            "Инженерная экономика и промышленная коммерция",
                            "Финансовая аналитика и аудит"
                        },
                        Description = "Экономическая теория, финансы, бухгалтерский учёт, анализ хозяйственной деятельности, аудит.",
                        CareerProspects = "Экономист, финансовый аналитик, бухгалтер, аудитор, банковский специалист"
                    },
                    new Direction
                    {
                        Code = "Economics.Management",
                        Name = "Менеджмент",
                        FacultyCode = "Economics",
                        Profiles = new List<string>
                        {
                            "Маркетинг и логистика в бизнесе",
                            "Логистика и управление цепями поставок",
                            "Маркетинг",
                            "Цифровой маркетинг",
                            "Управление цифровой экономикой"
                        },
                        Description = "Управление организацией, стратегический менеджмент, управление проектами, маркетинг.",
                        CareerProspects = "Менеджер, руководитель проекта, бизнес-аналитик, директор, предприниматель"
                    },
                    new Direction
                    {
                        Code = "Economics.PublicAdministration",
                        Name = "Государственное и муниципальное управление",
                        FacultyCode = "Economics",
                        Profiles = new List<string>
                        {
                            "Система государственного и муниципального управления"
                        },
                        Description = "Управление в государственных и муниципальных структурах, государственная служба, местное самоуправление.",
                        CareerProspects = "Государственный служащий, специалист администрации, муниципальный служащий"
                    },
                    new Direction
                    {
                        Code = "Economics.PedagogicalEducation",
                        Name = "Педагогическое образование",
                        FacultyCode = "Economics",
                        Profiles = new List<string>
                        {
                            "Экономика и информатика"
                        },
                        Description = "Подготовка учителей экономики и информатики для школ и колледжей.",
                        CareerProspects = "Учитель экономики, учитель информатики, методист, преподаватель колледжа"
                    },
                    new Direction
                    {
                        Code = "Economics.Innovation",
                        Name = "Инноватика",
                        FacultyCode = "Economics",
                        Profiles = new List<string>
                        {
                            "Управление инновациями на предприятиях"
                        },
                        Description = "Управление инновационными проектами, внедрение новых технологий, стартапы, бизнес-инкубаторы.",
                        CareerProspects = "Менеджер по инновациям, специалист технопарка, основатель стартапа"
                    },
                    new Direction
                    {
                        Code = "Economics.Sociology",
                        Name = "Социология",
                        FacultyCode = "Economics",
                        Profiles = new List<string>
                        {
                            "Социология маркетинга и рекламы",
                            "Социология маркетинга"
                        },
                        Description = "Социологические исследования, анализ общественного мнения, маркетинговые исследования.",
                        CareerProspects = "Социолог, маркетолог-аналитик, специалист по исследованиям рынка, PR-специалист"
                    },
                    new Direction
                    {
                        Code = "Economics.SocialWork",
                        Name = "Социальная работа",
                        FacultyCode = "Economics",
                        Profiles = new List<string>
                        {
                            "Социальное проектирование и предпринимательство",
                            "Социальная работа в организациях различных сфер деятельности"
                        },
                        Description = "Работа с социально незащищёнными группами населения, социальная поддержка, реабилитация.",
                        CareerProspects = "Социальный работник, специалист органов соцзащиты, специалист по работе с семьёй"
                    },
                    new Direction
                    {
                        Code = "Economics.HRM",
                        Name = "Управление персоналом",
                        FacultyCode = "Economics",
                        Profiles = new List<string>
                        {
                            "Управление персоналом в организации"
                        },
                        Description = "Управление человеческими ресурсами, рекрутинг, мотивация персонала, обучение и развитие сотрудников.",
                        CareerProspects = "HR-менеджер, рекрутер, специалист по обучению и развитию, менеджер по персоналу"
                    }
                }
            }
        };
    }

    // Получить факультет по коду
    public static Faculty? GetFacultyByCode(string code)
    {
        return GetAllFaculties().FirstOrDefault(f => f.Code == code);
    }

    // Получить направление по коду
    public static Direction? GetDirectionByCode(string code)
    {
        var allDirections = GetAllFaculties()
            .SelectMany(f => f.Directions)
            .ToList();
        
        return allDirections.FirstOrDefault(d => d.Code == code);
    }

    // Получить все направления факультета
    public static List<Direction> GetDirectionsByFaculty(string facultyCode)
    {
        var faculty = GetFacultyByCode(facultyCode);
        return faculty?.Directions ?? new List<Direction>();
    }
}