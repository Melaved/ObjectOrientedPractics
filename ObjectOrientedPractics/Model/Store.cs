using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Представляет магазин, содержащий товары и покупателей.
/// </summary>
public class Store
{
    /// <summary>
    /// Список товаров.
    /// </summary>
    private List<Item> _items;
    /// <summary>
    /// Список клиентов.
    /// </summary>
    private List<Customer> _customers;

    /// <summary>
    /// Свойство для получения или установки списка товаров.
    /// </summary>
    public List<Item> Items
    {
        get 
        { 
            return _items;
        }
        set
        {
            _items = value; 
        }
    }
    /// <summary>
    /// Свойство для получения или установки списка покупателей.
    /// </summary>
    public List<Customer> Customers
    {
        get
        { 
            return _customers; 
        }
        set 
        {
            _customers = value; 
        }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Store"/>.
    /// Конструктор создает пустые списки для товаров и клиентов.
    /// </summary>
    public Store()
    {
        Items = new List<Item>();
        Customers = new List<Customer>();
    }


}
