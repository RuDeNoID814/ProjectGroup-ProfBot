namespace ProjectGroup.models;

// Модели факультетов

public class Faculty
{
    public string Name { get; set; } // Название факультета
    public string Description { get; set; } // Описание факультета
    public List<Direction> Directions  { get; set; } // Направления факультета
}
public class Direction
{
    public string Name { get; set; } 
    public List<string> Profiles { get; set; } // Профили внутри направления
}