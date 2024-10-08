/// <summary>
/// Генерирует значения для переменных _id.
/// </summary>
public class IdGenerator
{
    /// <summary>
    /// Значение следующего идентификатора.
    /// </summary>
    public static int _nextId = 1;
    
    /// <summary>
    /// Прибавляет единицу к следующему идентификатору.
    /// </summary>
    /// <returns>Возвращает значение идентификатора</returns>
    public static int GetNextId()
    {
        return _nextId++;
    }
}