namespace ProjectGroup.services;

using ProjectGroup.models;

// Подсчёт результатов теста
public class ResultService
{
    // Определить лидирующий факультет
    public string GetLeadingFaculty(Dictionary<string, int> facultyScores)
    {
        if (facultyScores.Count == 0)
            return "Unknown";
        
        // Находим максимальный балл
        var maxScore = facultyScores.Values.Max();
        
        // Находим все факультеты с максимальным баллом (на случай ничьи)
        var leaders = facultyScores
            .Where( f => f.Value == maxScore )
            .Select( f => f.Key )
            .ToList();
        
        // Если победитель один - возвращаем его
        if (leaders.Count == 1)
            return leaders[0];
        
        // Если ничья - возвращаем первый (можно потом доработать)
        return leaders[0];
    }
    
    // Определить лидирующие направление внутри факультета
    public string GetLeadingDirection(Dictionary<string, int> directionScores, string faculty)
    {
        // Фильтруем только направления этого факультета
        var facultyDirections = directionScores
            .Where(d => d.Key.StartsWith(faculty + '.'))
            .ToList();
        
        if (facultyDirections.Count == 0)
            return "Unknown";
        
        // Находим направление с максимальным баллом
        return facultyDirections.MaxBy(d => d.Value).Key;
    }
    
    // Получить топ 3 направления
    public List<(string direction, int score)> GetTopDirections(Dictionary<string, int> directionScores, string faculty,
        int count = 3)
    {
        return directionScores
            .Where(d => d.Key.StartsWith(faculty + "."))
            .OrderByDescending(d => d.Value) // сортируем по убыванию баллов
            .Take(count) // берем топ 3
            .Select(d => (d.Key, d.Value)) // Преобразуем в кортеж
            .ToList();
    }
    
    // Проверить, есть ли ничья между факультетами
    public bool IsTie(Dictionary<string, int> facultyScores)
    {
        if (facultyScores.Count == 0)
            return false;
        
        var maxScore = facultyScores.Values.Max();
        var leadersCount = facultyScores.Count(f => f.Value == maxScore);
        
        return leadersCount > 1; // если больше 1 - ничья
    }
}