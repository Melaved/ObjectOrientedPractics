/// <summary>
/// Хранит данные о покупателе.
/// </summary>
public class Customer
{
    /// <summary>
    /// Уникальный идентификатор для всех объектов данного класса.
    /// </summary>
    private readonly int _id;

    /// <summary>
    /// Уникальное имя покупателя(customer).
    /// </summary>
    private string _fullname;

    /// <summary>
    /// Уникальное поле с адресом доставки для покупателя.
    /// </summary>
    public Address Address { get; set; }



    /// <summary>
    /// Возвращает и задает полное имя покупателя.
    /// </summary>
    public string FullName
    {
        get
        {
            return _fullname;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 200, "FullName");
            _fullname = value;
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
    /// Создаёт экземпляр класса <see cref="Customer"/>.
    /// </summary>
    /// <param name="fullName">Полное имя покупателя. Должно состоять только из
    ///букв.</param>
    /// <param name="address">Адрес доставки. Должен состоять только из
    ///букв.</param>
    public Customer(string fullName, Address address)
    {
        _id = IdGenerator.GetNextId();
        FullName = fullName;
        Address = new Address();
    }


    /// <summary>
    /// Конструктор по умолчанию.
    /// </summary>

    public Customer()
    {
        _id = IdGenerator.GetNextId();
        FullName = string.Empty;
        Address = new Address();
    }
}

