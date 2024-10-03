﻿using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//namespace ObjectOrientedPractics.View.Tabs
//{
//    public partial class CustomerTab : UserControl
//    {
//        /// <summary>
//        /// Список элементов класса <see cref="Customer"/>
//        /// </summary>
//        private List<Customer> items = new List<Customer>();

//        private AddressControl addressControl;

//        public CustomerTab()
//        {
//            InitializeComponent();
//            addressControl = new AddressControl(CustomerslistBox);
//            idTextBox.ReadOnly = true;
//        }

//        private void AddButton_Click(object sender, EventArgs e)
//        {
//            string fullName = fullNameTextBox.Text;
//            Address address = addressControl.Address;
//            Customer newCustomer = new Customer(fullName, address);

//            items.Add(newCustomer);

//            UpdateListBox();

//            ClearFields();
//        }
//        private void UpdateListBox()
//        {
//            CustomerslistBox.DataSource = null;
//            CustomerslistBox.DataSource = items;
//            CustomerslistBox.DisplayMember = "Display";
//        }

//        private void ClearFields()
//        {
//            fullNameTextBox.Clear();
//            addressControl.Address = new Address(); // Очищаем AddressControl
//        }
//    }
//}


namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomerTab : UserControl
    {
        /// <summary>
        /// Список элементов класса <see cref="Customer"/>
        /// </summary>
        private List<Customer> customers = new List<Customer>();

        private AddressControl addressControl;

        public CustomerTab()
        {
            InitializeComponent();
            addressControl = new AddressControl();
            idTextBox.ReadOnly = true; 
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string fullName = fullNameTextBox.Text;

            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Полное имя покупателя не может быть пустым.");
                return;
            }

            Address address = addressControl.Address;

            if (address == null)
            {
                MessageBox.Show("Адрес доставки не может быть пустым.");
                return;
            }

            Customer newCustomer = new Customer(fullName, address);
            customers.Add(newCustomer);

            UpdateListBox();
            ClearFields();
        }

        private void UpdateListBox()
        {
            CustomerslistBox.DataSource = null;
            CustomerslistBox.DataSource = customers; 
            CustomerslistBox.DisplayMember = "Display"; 
        }

        private void ClearFields()
        {
            fullNameTextBox.Clear(); 
            addressControl.ClearFields(); 
        }
        private void CustomerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerslistBox.SelectedItem is Customer selectedCustomer)
            {
                fullNameTextBox.Text = selectedCustomer.FullName;
                addressControl.Address = selectedCustomer.Address;
            }
        }
    }
}
