//using ObjectOrientedPractics.View.Controls;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//namespace ObjectOrientedPractics.View.Tabs
//{
//    public partial class CustomerTab : UserControl
//    {
//        /// <summary>
//        /// List of customers.
//        /// </summary>
//        private List<Customer> _customers = new List<Customer>();

//        /// <summary>
//        /// Variable - Customer type.
//        /// </summary>
//        private Customer _currentCustomer = new Customer();

//        /// <summary>
//        /// Reterns and sets a list of cistomers.
//        /// </summary>
//        //public List<Customer> Customers { get { return _customers; } set { _customers = value; } }


//        private AddressControl _addressControl = new AddressControl();

//        public CustomerTab()
//        {
//            InitializeComponent();
//        }


//        /// <summary>
//        /// Обновляет отображаемый список покупателей в элементе управления.
//        /// </summary>
//        private void UpdateListBox()
//        {
//            CustomersListBox.Items.Clear();

//            foreach (Customer customer in _customers)
//            {
//                CustomersListBox.Items.Add($"{customer.Id} / {customer.FullName}");
//            }
//        }


//        private void ClearItemInfo()
//        {
//            FullNameTextBox.Clear();
//            FullNameTextBox.BackColor = Color.White;
//            idTextBox.Clear();
//        }

//        private Customer AddItemsInfo()
//        {
//            string fullname = FullNameTextBox.Text;
//            return new Customer(fullname, _addressControl.AddInfoFromTextBox());
//        }

//        private void UpdateItemInfo()
//        {
//            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
//            idTextBox.Text = _currentCustomer.Id.ToString();
//            FullNameTextBox.Text = _currentCustomer.FullName.ToString();
//            Address selectedAddress = _currentCustomer.CustomerAddress;
//            _addressControl.SelelctedTextBoxs(selectedAddress);
//        }

//        private void AddButton_Click(object sender, EventArgs e)
//        {

//            try
//            {
//                // Create a list of TextBoxes to check
//                var textBoxes = new List<System.Windows.Forms.TextBox>
//                { FullNameTextBox };
//                bool ifRed = true;

//                foreach (var textBox in textBoxes)
//                {
//                    if (textBox.BackColor == Color.LightPink)
//                    {
//                        ifRed = false;
//                    }
//                }

//                // Check TextBoxes if they are empty or red
//                if (textBoxes.All(tb => !string.IsNullOrWhiteSpace(tb.Text)) && ifRed)
//                {
//                    Customer selectedCustomer = AddItemsInfo();
//                    _customers.Add(selectedCustomer);
//                    UpdateListBox();
//                }
//                else
//                {
//                    throw new Exception("Incorrect values.");
//                }
//            }
//            catch (Exception ex)
//            {
//                // Error message
//                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
//                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
//            }
//            //Customer selectedCustomer = AddItemsInfo();
//            //_customers.Add(selectedCustomer);
//            //UpdateListBox();
//        }


//        private void RemoveButton_Click_1(object sender, EventArgs e)
//        {
//            if (CustomersListBox.SelectedIndex == -1)
//            {
//                // No chosen elements error message
//                MessageBox.Show(
//                    "You didnt choose an object to delete it.",
//                    "Error",
//                    MessageBoxButtons.OK,
//                    MessageBoxIcon.Error,
//                    MessageBoxDefaultButton.Button1);
//                return;
//            }
//            _customers.RemoveAt(CustomersListBox.SelectedIndex);
//            CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
//            ClearItemInfo();
//        }

//        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            if (CustomersListBox.SelectedItem != null)
//            {
//                UpdateListBox();
//            }
//        }

//        private void fullNameTextBox_TextChanged_1(object sender, EventArgs e)
//        {
//            try
//            {
//                _currentCustomer.FullName = FullNameTextBox.Text;
//                FullNameTextBox.BackColor = Color.White;
//            }
//            catch (ArgumentException)
//            {
//                FullNameTextBox.BackColor = Color.LightPink;
//            }
//        }
//    }
//}

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;

using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomerTab : UserControl
    {
        /// <summary>
        /// List of customers.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Variable - Customer type.
        /// </summary>
        private Customer _currentCustomer = new Customer();

        /// <summary>
        /// Reterns and sets a list of cistomers.
        /// </summary>
        public List<Customer> Customers { get { return _customers; } set { _customers = value; } }


        private AddressControl _addressControl = new AddressControl();

        public CustomerTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generates object of Customer with the help of TextBox.
        /// </summary>
        private Customer AddItemsInfo()
        {
            string fullname = FullNameTextBox.Text;
            return new Customer(fullname, _addressControl.AddInfoFromTextBox());
        }

        /// <summary>
        /// Updates elements in ItemsListBox.
        /// </summary>
        private void UpdateListBox()
        {
            CustomersListBox.Items.Clear();

            foreach (Customer customer in _customers)
            {
                CustomersListBox.Items.Add($"{customer.Id} / {customer.Fullname}");
            }
        }

        /// <summary>
        /// Clears info about a customer in the TextBox.
        /// </summary>
        private void ClearItemInfo()
        {
            FullNameTextBox.Clear();
            FullNameTextBox.BackColor = Color.White;
            idTextBox.Clear();
        }

        /// <summary>
        /// Updates info about a customer in the TextBox.
        /// </summary>
        private void UpdateItemInfo()
        {
            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
            idTextBox.Text = _currentCustomer.Id.ToString();
            FullNameTextBox.Text = _currentCustomer.Fullname.ToString();
            Address selectedAddress = _currentCustomer.CustomerAddress;
            _addressControl.SelelctedTextBoxs(selectedAddress);
        }

        private void fullNameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.Fullname = FullNameTextBox.Text;
                FullNameTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                FullNameTextBox.BackColor = Color.LightPink;
            }
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a list of TextBoxes to check
                var textBoxes = new List<System.Windows.Forms.TextBox>
                { FullNameTextBox };
                bool ifRed = true;

                foreach (var textBox in textBoxes)
                {
                    if (textBox.BackColor == Color.LightPink)
                    {
                        ifRed = false;
                    }
                }

                // Check TextBoxes if they are empty or red
                if (textBoxes.All(tb => !string.IsNullOrWhiteSpace(tb.Text)) && ifRed)
                {
                    Customer selectedCustomer = AddItemsInfo();
                    _customers.Add(selectedCustomer);
                    UpdateListBox();
                }
                else
                {
                    throw new Exception("Incorrect values.");
                }
            }
            catch (Exception ex)
            {
                // Error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void RemoveButton_Click_1(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                // No chosen elements error message
                MessageBox.Show(
                    "You didnt choose an object to delete it.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
            _customers.RemoveAt(CustomersListBox.SelectedIndex);
            CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
            ClearItemInfo();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem != null)
            {
                UpdateListBox();
            }
        }

        private void CustomerListBox_DoubleClick(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem != null)
            {
                UpdateListBox();
            }
        }
    }
}