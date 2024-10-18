namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {

        private Store _store = new Store();
        public MainForm()
        {
            InitializeComponent(); 
            itemsTab1.Items = _store.Items;
            customerTab1.Customer = _store.Customers;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
