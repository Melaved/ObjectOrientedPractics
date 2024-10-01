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
    private string _adress;

    /// <summary>
    /// Переменная валидатор для строк.
    /// </summary>
    private ValueValidator _validator = new ValueValidator();

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
            _validator.AssertStringOnLength(value, 200, nameof(value));
            _fullname = value; 
        }
    }

    /// <summary>
    /// Возвращает и задает адрес доставки.
    /// </summary>
    public string Adress
    {
        get
        {
            return _adress;
        }
        set
        {
            _validator.AssertStringOnLength(value, 500, nameof(value));
            _adress = value;
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Customer"/>.
    /// </summary>
    /// <param name="fullName">Полное имя покупателя. Должно состоять только из
    ///букв.</param>
    /// <param name="adress">Адрес доставки. Должен состоять только из
    ///букв.</param>
    public Customer(string fullName, string adress)
    {
        _id = IdGenerator.GetNextId();
        FullName = fullName;
        Adress = adress;
        
    }
}