//using System.Net;
//using System.Xml.Linq;

///// <summary>
///// Хранит данные о покупателе.
///// </summary>
//public class Customer
//{
//    /// <summary>
//    /// Уникальный идентификатор для всех объектов данного класса.
//    /// </summary>
//    private readonly int _id;

//    /// <summary>
//    /// Уникальное имя покупателя(customer).
//    /// </summary>
//    private string _fullname;

//    /// <summary>
//    /// Уникальное поле с адресом доставки для покупателя.
//    /// </summary>
//    private Address _address = new Address();



//    /// <summary>
//    /// Возвращает и задает полное имя покупателя.
//    /// </summary>
//    public string FullName 
//    { 
//        get 
//        { 
//            return _fullname; 
//        }
//        set 
//        {
//            ValueValidator.AssertStringOnLength(value, 200, "FullName");
//            _fullname = value; 
//        }
//    }

//    /// <summary>
//    /// Возвращает идентификатор.
//    /// </summary>
//    public int Id
//    {
//        get
//        {
//            return _id;
//        }
//    }

//    /// <summary>
//    /// Возвращает и задает адрес доставки.
//    /// </summary>
//    public Address CustomerAddress
//    {
//        get
//        {
//            return _address;
//        }
//        set
//        {

//            _address = value;

//        }
//    }

//    /// <summary>
//    /// Возвращает отображение покупателя в меню.
//    /// </summary>
//    public string Display
//    {
//        get
//        {
//            return $"ID: {_id}, Name: {_fullname}";
//        }
//    }

//    /// <summary>
//    /// Создаёт экземпляр класса <see cref="Customer"/>.
//    /// </summary>
//    /// <param name="fullName">Полное имя покупателя. Должно состоять только из
//    ///букв.</param>
//    /// <param name="address">Адрес доставки. Должен состоять только из
//    ///букв.</param>
//    public Customer(string fullName, Address address)
//    {
//        _id = IdGenerator.GetNextId();
//        FullName = fullName;
//        CustomerAddress = address;
//    }




//    public Customer()
//    {
//        _id = IdGenerator.GetNextId();
//        FullName = string.Empty;
//        CustomerAddress = new Address();
//    }
//}




namespace ObjectOrientedPractics.Model
{

    /// <summary>
    /// Holds data of a customer.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Unique customer number.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Full name of a customer.
        /// </summary>
        private string _fullname = string.Empty;

        /// <summary>
        /// Delivery address.
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Returns unique id of a customer.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Gets and sets an address for delivery.
        /// </summary>
        public Address CustomerAddress
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Gets and sets the full name of a customer.
        /// </summary>
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(_fullname));
                _fullname = value;
            }
        }



        /// <summary>
        /// Creates a sample of a class  <see cref="Item"/>.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя.</param>
        /// <param name="address">Адрес доставки для покупателя.</param>

        public Customer(string fullname, Address address)
        {
            Fullname = fullname;
            CustomerAddress = address;
            _id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Creates an empty sample of a class <see cref="Item"/>.
        /// </summary>

        public Customer()
        {
            Fullname = string.Empty;
            CustomerAddress = new Address();
            _id = IdGenerator.GetNextId();
        }
    }
}