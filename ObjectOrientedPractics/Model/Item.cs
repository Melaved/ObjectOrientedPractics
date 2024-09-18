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
    private string _name { get; set; }

    /// <summary>
    /// Информация о товаре.
    /// </summary>
    private string _info { get; set; }

    /// <summary>
    /// Стоимость товара.
    /// </summary>
    private double _cost { get; set; }


    /// <summary>
    /// Переменная класса, хранящего метод валидации строк
    /// </summary>
    private ValueValidator _validator = new ValueValidator();

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Item"/>.
    /// </summary>
    public Item()
    {
        _id = IdGenerator.GetNextId();
    }

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
        _name = name;

        _info = info;

        _cost = cost;

        _validator.AssertStringOnLength(name, 200, nameof(name));

        _validator.AssertStringOnLength(info, 1000, nameof(name));
    }
}