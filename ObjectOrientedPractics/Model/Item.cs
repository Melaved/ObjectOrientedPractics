using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using System.ComponentModel.DataAnnotations;
// using System.Reflection.Emit;

using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товарах.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Уникальный номер товара.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает уникальный номер товара.
        /// </summary>
        public int Id 
        { 
            get 
            { 
                return _id;
            } 
        }

        /// <summary>
        /// Получает и устанавливает название товара.
        /// </summary>
        public string Name
        {
            get
            { 
                return _name; 
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(_name));
                _name = value;
            }
        }

        /// <summary>
        /// Получает и устанавливает описание товара.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(_info));
                _info = value;
            }
        }

        /// <summary>
        /// Получает и устанавливает стоимость товара.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 0, 100000, nameof(_cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Получает и устанавливает категорию товара. <see cref="Item"/>.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Описание товара.</param>
        /// <param name="cost">Стоимость товара.</param>
        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _id = IdGenerator.GetNextId();
            Category = new Category();
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            Name = string.Empty;
            Info = string.Empty;
            Cost = 0;
            _id = IdGenerator.GetNextId();
            Category = new Category();
        }
    }
}
