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
    /// 
    /// </summary>
    public Item()
    {
        _id = IdGenerator.GetNextId();
    }
    
    public Item(string name , string info, double cost)
    {
        _name = name;

        _info = info;

        _cost = cost;

        _validator.AssertStringOnLength(name, 200, nameof(name));

        _validator.AssertStringOnLength(info, 1000, nameof(name));
    }
}