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
    private string _name;

    /// <summary>
    /// Информация о товаре.
    /// </summary>
    private string _info;

    /// <summary>
    /// Стоимость товара.
    /// </summary>
    private double _cost;

    /// <summary>
    /// Возвращает отображение товара в меню.
    /// </summary>
    public string Display
    {
        get
        {
            return $"ID: {_id}, Name: {_name}, Cost {_cost}";
        }
    }

    /// <summary>
    /// Возвращает идентификатор.
    /// </summary>
    public int Id
    {
        get
        {
            return _id;
        }
    }

    /// <summary>
    /// Переменная класса, хранящего метод валидации строк
    /// </summary>
    private ValueValidator _validator = new ValueValidator();

    /// <summary>
    /// Возвращает и задает название предмета(товара).
    /// </summary>
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _validator.AssertStringOnLength(value, 200, nameof(_name));
            _name = value;
        }
    }

    /// <summary>
    /// Возвращает и задает информацию о товаре.
    /// </summary>
    public string Info
    {
        get
        {
            return _info;
        }
        set
        {
            _validator.AssertStringOnLength(value, 1000, nameof(_info));
            _info = value;
        }
    }

    /// <summary>
    /// Возвращает и задает стоимость товара.
    /// </summary>
    public double Cost
    {
        get
        {
            return _cost;
        }
        set
        {
            if (!IsCostValid(value))
            {
                throw new ArgumentException($"{value} должен быть больше 0 и меньше 100000");
            }
            _cost = value;
        }
    }

    /// <summary>
    /// Проверяет, что стоимость в нужном диапазоне значений.
    /// </summary>
    /// <param name="value">Проверяемая строка.</param>
    /// <returns>Возвращает true, если значение стоимости подходит.
    ///И false, если нет.</returns>
    public bool IsCostValid(double value)
    {
        return value > 0.0 && value < 100000.0;
    }

    /// <summary>
    /// Переменная класса, хранящего метод валидации строк
    /// </summary> 
    /// <summary>
    /// Создаёт экземпляр класса <see cref="Item"/>.
    /// </summary>
    /// <param name="name">Имя Должно состоять только из
    ///букв.</param>
    /// <param name="info">Информация. Должна состоять только из
    ///букв.</param>
    /// <param name="cost">Стоимость. Должна быть вещественным числом.
    /// </param>
    public Item(string name, string info, double cost)
    {
        _id = IdGenerator.GetNextId();

        Name = name;

        Info = info;

        Cost = cost;
    }
}






//using System.Xml.Linq;

///// <summary>
///// Хранит данные о товаре.
///// </summary>
//class Item
//{
//    /// <summary>
//    /// Уникальный идентификатор для всех объектов данного класса.
//    /// </summary>
//    private readonly int _id;

//    /// <summary>
//    /// Уникальное имя товара.
//    /// </summary>
//    internal string _name { get; private set; }

//    /// <summary>
//    /// Информация о товаре.
//    /// </summary>
//    internal string _info { get; private set; }

//    /// <summary>
//    /// Стоимость товара.
//    /// </summary>
//    internal double _cost { get; private set; }

//    /// <summary>
//    /// Отображение товара в меню.
//    /// </summary>
//    public string Display
//    {
//        get
//        {
//            return $"ID: {_id}, Name: {_name}, Cost {_cost}";
//        }
//    }
//    public int Id
//    {
//        get
//        {
//            return _id;
//        }
//    }

//    /// <summary>
//    /// Переменная класса, хранящего метод валидации строк
//    /// </summary>
//    private ValueValidator _validator = new ValueValidator();

//    /// <summary>
//    /// Создаёт экземпляр класса <see cref="Item"/>.
//    /// </summary>
//    /// <param name="name">Имя Должно состоять только из
//    ///букв.</param>
//    /// <param name="info">Информация. Должна состоять только из
//    ///букв.</param>
//    /// <param name="cost">Стоимость. Должна быть вещественным числом.
//    /// </param>
//    public Item(string name, string info, double cost)
//    {
//        _id = IdGenerator.GetNextId();

//        _validator.AssertStringOnLength(name, 200, nameof(name));

//        _validator.AssertStringOnLength(info, 1000, nameof(name));

//        _name = name;

//        _info = info;

//        _cost = cost;
//    }
//}































