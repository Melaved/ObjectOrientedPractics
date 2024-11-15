using System;
using System.Collections.Generic;
using System.Linq;
using ObjectOrientedPractics.Services;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные клиента.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный номер клиента.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя клиента.
        /// </summary>
        private string _fullname = string.Empty;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Новая переменная типа Cart.                                 
        /// </summary>
        private Cart _cart = new Cart();

        /// <summary>
        /// Список заказов.                                            
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary> 
        /// Получает и устанавливает данные корзины.                                      
        /// </summary>
        public Cart CustomerCart
        {
            get { return _cart; }
            set { _cart = value; }
        }

        public List<IDiscount> Discounts { get; set; }

        /// <summary>
        /// Возвращает уникальный идентификатор клиента.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Получает и устанавливает адрес для доставки.
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
        /// Получает и устанавливает полное имя клиента.
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
        /// Получает и устанавливает список заказов.
        /// </summary>
        public List<Order> Orders
        {
            get
            {
                return _orders;
            }
            set
            {
                _orders = value;
            }
        }

        /// <summary>
        /// Возвращает и задает приоритетность заказа.
        /// </summary>
        public bool IsPriority { get; set; } = false;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="fullname">Полное имя клиента.</param>
        public Customer(string fullname)
        {
            Fullname = fullname;
            CustomerAddress = new Address();
            _id = IdGenerator.GetNextId();
            CustomerCart = new Cart();
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Customer()
        {
            Fullname = string.Empty;
            CustomerAddress = new Address();
            _id = IdGenerator.GetNextId();
            CustomerCart = new Cart();
            Orders = new List<Order>();
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
        }
    }
}
