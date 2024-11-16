using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о заказе клиента.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private readonly DateTime _date = DateTime.Now;

        /// <summary>
        /// Возвращает уникальный идентификатор.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        public DateTime Date
        {
            get
            {
                return _date;
            }
        }

        /// <summary>
        /// Получает и устанавливает статус заказа.
        /// </summary>
        public OrderStatus Status { get; set; } = OrderStatus.New;

        /// <summary>
        /// Получает и устанавливает адрес доставки.
        /// </summary>
        public Address Address { get; set; } = new Address();

        /// <summary>
        /// Получает и устанавливает список новых товаров.                                 
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();

        /// <summary>
        /// Получает общую стоимость заказа.
        /// </summary>
        public double Amount
        {
            get
            {
                if (Items.Count != 0 && Items != null)
                {
                    double amount = 0.0;
                    foreach (var item in Items)
                    {
                        amount += item.Cost;
                    }
                    return amount;
                }
                else
                {
                    return 0.0;
                }
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров.</param>
        public Order(Address address, List<Item> items)
        {
            _id = IdGenerator.GetNextId();
            Status = new OrderStatus();
            Address = address;
            _date = DateTime.Now;
            foreach (Item item in items)
            {
                Items.Add(item);
            }
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Now;
            Status = new OrderStatus();
            Items = new List<Item>();
        }
    }
}
