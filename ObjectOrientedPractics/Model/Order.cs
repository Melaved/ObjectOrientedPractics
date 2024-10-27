/// <summary>
/// 
/// </summary>
public class Order
{
    private readonly int _id;

    private readonly DateTime _date = DateTime.Now;

    public int Id
    {
        get
        {
            return _id;
        }
    }

    public DateTime Date
    {
        get
        {
            return _date;
        }
    }

    public OrderStatus Status { get; set; } = OrderStatus.New;

    public Address Address { get; set; } = new Address();

    public List<Item> Items { get; set; } = new List<Item>();

    public double Amount
    {
        get
        {
            double amount = 0.0;
            foreach (Item item in Items)
            {
                amount += item.Cost;
            }
            return amount;
        }
    }

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

    public Order()
    {
        _id = IdGenerator.GetNextId();
        _date = DateTime.Now;
        Status = new OrderStatus();
        Items = new List<Item>();
    }
}