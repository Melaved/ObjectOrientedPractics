using System.Xml.Linq;

/// <summary>
/// Хранит данные о товаре.
/// </summary>
class Item
{
    /// <summary>
    /// Уникальный идентификатор для всех объектов данного класса.
    /// </summary>
    private readonly int _id;

    /// <summary>
    /// Уникальное имя товара.
    /// </summary>
    internal string _name { get;private set; }

    /// <summary>
    /// Информация о товаре.
    /// </summary>
    internal string _info { get;private set; }

    /// <summary>
    /// Стоимость товара.
    /// </summary>
    internal double _cost { get;private set; }
    public string Display => $"ID: {_id}, Name: {_name}";
    public int Id => _id;

    /// <summary>
    /// Переменная класса, хранящего метод валидации строк
    /// </summary>
    private ValueValidator _validator = new ValueValidator();

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Item"/>.
    /// </summary>
    /// <param name="name">Имя Должно состоять только из
    ///букв.</param>
    /// <param name="info">Информация. Должна состоять только из
    ///букв.</param>
    /// <param name="cost">Стоимость. Должна быть вещественным числом.
    /// </param>
    public Item(string name , string info, double cost)
    {
        _id = IdGenerator.GetNextId();

        _name = name;

        _info = info;

        _cost = cost;

        _validator.AssertStringOnLength(name, 200, nameof(name));

    }
}