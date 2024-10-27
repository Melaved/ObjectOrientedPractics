public class Cart
{
    private List<Item> _items =  new List<Item>();

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

    public double Amount
    {
        get 
        {
            double amount = 0.0;
            foreach (Item item in _items)
            {
                amount += item.Cost;
            }
            return amount;
        }
    }
}
