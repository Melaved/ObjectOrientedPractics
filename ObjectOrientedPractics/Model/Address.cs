/// <summary>
/// Хранит данные об адрессе покупателя.
/// </summary>
public class Address
{
    /// <summary>
    /// Уникальный индекс покупателя
    /// </summary>
    private int _index;

    /// <summary>
    /// Страна клиента.
    /// </summary>
    private string _country;

    /// <summary>
    /// Город клиента.
    /// </summary>
    private string _city;

    /// <summary>
    /// Название улицы клиента.
    /// </summary>
    private string _street;

    /// <summary>
    /// Номер дома клиента.
    /// </summary>
    private string _building;

    /// <summary>
    /// Номер квартиры клиента.
    /// </summary>
    private string _apartment;

    /// <summary>
    /// Возвращает и задает номер индекса покупателя.
    /// </summary>
    public int Index 
    {  
        get
        { 
            return _index;
        } 
        set 
        {
            ValueValidator.AssertNumberOnValue(value, 100000, 999999,"Index");
            _index = value;
        }
    }

    /// <summary>
    /// Возвращает и задает название страны клиента.
    /// </summary>
    public string Country
    {
        get 
        {
            return _country;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 50, "Country");
            _country = value; 
        }
    }

    /// <summary>
    /// Возвращает и задает название города клиента
    /// </summary>
    public string City
    {
        get
        {
            return _city;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 50, "City");
            _city = value;
        }
    }

    /// <summary>
    /// Возвращает и задает название улицы клиента.
    /// </summary>
    public string Street
    {
        get
        {
            return _street;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 100, Street);
            _street = value;
        }
    }

    /// <summary>
    /// Возвращает и задает номер дома клиента.
    /// </summary>
    public string Building
    {
        get
        {
            return _building;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 10, Building);
            _building = value;
        }
    }

    /// <summary>
    /// Возвращает и задает номер квартиры клиента.
    /// </summary>
    public string Apartment
    {
        get
        {
            return _apartment;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value,10, "Apartment");
            _apartment = value;
        }
    }

    /// <summary>
    ///  Создаёт экземпляр класса <see cref="Address"/>.
    /// </summary>
    /// <param name="index"> Индекс. Должен быть целым, шестизначным числом.</param>
    /// <param name="country">Страна. Должна состоять только из символов.</param>
    /// <param name="city">Город. Должен состоять только из символов.</param>
    /// <param name="street">Улица. Должна состоять только  из симолов.</param>
    /// <param name="building">Номер дома. Должен состоять только из символов.</param>
    /// <param name="apartment">Номер квартиры. Должен состоять только из символов.</param>
    public Address(int index,string country, string city,string street,string building,string apartment)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        Building = building;
        Apartment = apartment;
    }

    /// <summary>
    /// Конструктор по умолчанию
    /// </summary>
    public Address()
    {
        Index = 100000;
        Country = "";
        City = "";
        Street = "";
        Building = "";
        Apartment = "";
    }

}
