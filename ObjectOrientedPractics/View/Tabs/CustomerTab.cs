
using ObjectOrientedPractics.View.Controls;
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
        /// Список элементов класса <see cref="Customer"/>
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Данные о текущем клиенте
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Список строк для отображения в списке клиентов.
        /// </summary>
        private List<string> CustomersListBoxItems = new List<string>();

        public CustomerTab()
        {
            InitializeComponent();
            idTextBox.ReadOnly = true;
        }

        /// <summary>
        /// Получает или задает список клиентов.
        /// При установке значения добавляет клиентов в ListBox.
        /// </summary>
        /// <value>Список объектов <see cref="Customer"/>, представляющий клиентов.</value>
        public List<Customer> Customer
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

        private void AddButton_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(FullNameTextBox.Text) || addressControl.AddressIsNullOrEmpty())
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            if (ValueValidator.IsNumeric(FullNameTextBox.Text))
            {
                MessageBox.Show("FullName должен состоять из букв");
                return;
            }

            Customer NewCustomer = new Customer();
            NewCustomer.FullName = FullNameTextBox.Text;
            NewCustomer.Address = addressControl.GiveValues();

            Customer.Add(NewCustomer);
            CustomersListBoxItems.Add($"{NewCustomer.Id} - {NewCustomer.FullName}");
            CustomersListBox.Items.Add(CustomersListBoxItems[CustomersListBoxItems.Count - 1]);

            ClearInfo();
        }


        /// <summary>
        /// Очищает все текстовые поля и сбрасывает цвет фона.
        /// </summary>
        private void ClearInfo()
        {
            idTextBox.Clear();
            FullNameTextBox.Clear();
            addressControl.ClearTextBox();
            FullNameTextBox.BackColor = Color.White;
        }


        private void RemoveButton_Click_1(object sender, EventArgs e)
        {
            int selectedIndex = CustomersListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                _customers.RemoveAt(selectedIndex);
                CustomersListBox.Items.RemoveAt(selectedIndex);
                _currentCustomer = null;
                ClearInfo();
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1 || CustomersListBox.Items.Count == 0)
            {
                addressControl.IsUpdatingFieldFlag = true;
                AddButton.Enabled = true;
                ClearInfo();
            }
            else
            {
                addressControl.IsUpdatingFieldFlag = false;
                AddButton.Enabled = false;
                int selectedIndex = CustomersListBox.SelectedIndex;
                if (selectedIndex == -1) return;
                _currentCustomer = Customer[selectedIndex];
                idTextBox.Text = _currentCustomer.Id.ToString();
                FullNameTextBox.Text = _currentCustomer.FullName;

                addressControl.UpdateData(_currentCustomer.Address);

            }
        }

        private void CustomersListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (CustomersListBox.IndexFromPoint(e.Location) == -1)
            {
                addressControl.IsUpdatingFieldFlag = false;
                CustomersListBox.ClearSelected();
                ClearInfo();
            }
        }
    }
}

