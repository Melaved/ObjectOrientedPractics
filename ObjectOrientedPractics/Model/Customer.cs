class Customer
{
    private readonly int _id;

    private string _fullname { get; set; }

    private string _adress { get; set; }

    private ValueValidator _validator = new ValueValidator();

    public Customer()
    {
        _id = IdGenerator.GetNextId();
    }

    public Customer(string fullName, string adress)
    {
        _fullname = fullName;
        _validator.AssertStringOnLength(fullName, 200, nameof(fullName));
        _adress = adress;
        _validator.AssertStringOnLength(adress, 500, nameof(adress));
    }
}