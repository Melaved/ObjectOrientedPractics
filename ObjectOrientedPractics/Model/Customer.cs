class Customer
{
    /// <summary>
    /// Уникальный идентификатор для всех объектов данного класса.
    /// </summary>
    private readonly int _id;

    /// <summary>
    /// Уникальное имя покупателя(customer).
    /// </summary>
    private string _fullname { get; set; }

    /// <summary>
    /// Уникальный поле с адресом доставки для покупателя.
    /// </summary>
    private string _adress { get; set; }

    /// <summary>
    /// Переменная валидатор для строк.
    /// </summary>
    private ValueValidator _validator = new ValueValidator();

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Customer"/>.
    /// </summary>
    public Customer()
    {
        _id = IdGenerator.GetNextId();
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
        _fullname = fullName;
        _adress = adress;
        _validator.AssertStringOnLength(fullName, 200, nameof(fullName));
        _validator.AssertStringOnLength(adress, 500, nameof(adress));
    }
}