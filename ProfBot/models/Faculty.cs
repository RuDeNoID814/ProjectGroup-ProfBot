namespace ProjectGroup.models;

// Модели факультетов

public class Faculty
{
    public string Code { get; set; } = string.Empty; // IIT, Math, Physics, Chemistry, Economics
    public string ShortName { get; set; } = string.Empty; // ИИТ, Матфак
    public string FullName { get; set; } = string.Empty; // Институт информационных технологий
    public string Description { get; set; } = string.Empty; // Краткое описание
    public string WebsiteUrl { get; set; } = string.Empty; // Ссылка на сайт ЧелГУ
    public string ContactInfo { get; set; } = string.Empty; // Телефон, email
    public List<Direction> Directions { get; set; } = new(); // Список направлений
}

// Модель направления подготовки
public class Direction
{
    public string Code { get; set; } = string.Empty; // IIT.AppliedInformatics
    public string Name { get; set; } = string.Empty; // Прикладная информатика
    public string FacultyCode { get; set; } = string.Empty; // Связь с факультетом
    public List<string> Profiles { get; set; } = new(); // Список профилей
    public string Description { get; set; } = string.Empty; // Что изучают
    public string CareerProspects { get; set; } = string.Empty; // Кем можно работать
}