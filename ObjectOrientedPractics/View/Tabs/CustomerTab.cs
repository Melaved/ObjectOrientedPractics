﻿using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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

        private AddressControl _addressControl;

        public CustomerTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generates object of Customer with the help of TextBox.
        /// </summary>
        private Customer AddItemsInfo()
        {
            string fullname = fullNameTextBox.Text;
            return new Customer(fullname, _addressControl.AddInfoFromTextBox());
        }

        /// <summary>
        /// Updates elements in ItemsListBox.
        /// </summary>
        private void UpdateListBox()
        {
            CustomerslistBox.Items.Clear();

            foreach (Customer customer in _customers)
            {
                CustomerslistBox.Items.Add($"{customer.Id} / {customer.FullName}");
            }
        }

        /// <summary>
        /// Clears info about a customer in the TextBox.
        /// </summary>
        private void ClearItemInfo()
        {
            fullNameTextBox.Clear();
            fullNameTextBox.BackColor = Color.White;
            idTextBox.Clear();
        }

        /// <summary>
        /// Updates info about a customer in the TextBox.
        /// </summary>
        private void UpdateItemInfo()
        {
            _currentCustomer = _customers[CustomerslistBox.SelectedIndex];
            idTextBox.Text = _currentCustomer.Id.ToString();
            fullNameTextBox.Text = _currentCustomer.FullName.ToString();
            Address selectedAddress = _currentCustomer.CustomerAddress;
            _addressControl.SelelctedTextBoxs(selectedAddress);
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.FullName = fullNameTextBox.Text;
                fullNameTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                fullNameTextBox.BackColor = Color.LightPink;
            }
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a list of TextBoxes to check
                var textBoxes = new List<System.Windows.Forms.TextBox>
                { fullNameTextBox };
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

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomerslistBox.SelectedIndex == -1)
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
            _customers.RemoveAt(CustomerslistBox.SelectedIndex);
            CustomerslistBox.Items.RemoveAt(CustomerslistBox.SelectedIndex);
            ClearItemInfo();
        }

        private void CustomerslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerslistBox.SelectedItem != null)
            {
                UpdateListBox();
            }
        }

        private void CustomerslistBox_DoubleClick(object sender, EventArgs e)
        {
            if (CustomerslistBox.SelectedItem != null)
            {
                UpdateListBox();
            }
        }
    }
}





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
//        public List<Customer> Customers { get { return _customers; } set { _customers = value; } }


//        public CustomerTab()
//        {
//            InitializeComponent();
//        }


//    }
//}