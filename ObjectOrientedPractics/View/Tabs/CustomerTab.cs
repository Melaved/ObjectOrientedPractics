using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomerTab : UserControl
    {
        /// <summary>
        /// Список элементов класса <see cref="Customer"/>
        /// </summary>
        private List<Customer> items = new List<Customer>();

        private AddressControl addressControl;

        public CustomerTab()
        {
            InitializeComponent();
            addressControl = new AddressControl(CustomerslistBox);
            idTextBox.ReadOnly = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string fullName = fullNameTextBox.Text;
            Address address = addressControl.Address;
            Customer newCustomer = new Customer(fullName, address);

            // Добавление в список
            items.Add(newCustomer);

            // Обновление ListBox
            UpdateListBox();

            // Очистка полей
            ClearFields();
        }
        private void UpdateListBox()
        {
            CustomerslistBox.DataSource = null;
            CustomerslistBox.DataSource = items;
            CustomerslistBox.DisplayMember = "Name";
        }

        private void ClearFields()
        {
            fullNameTextBox.Clear();
            addressControl.Address = new Address(); // Очищаем AddressControl
        }
    }
}
