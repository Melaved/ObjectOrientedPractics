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
        private List<Customer> items = new List<Customer>();

        private AddressControl addressControl;

        public CustomerTab()
        {
            InitializeComponent();
            addressControl = new AddressControl(CustomerslistBox);
            idTextBox.ReadOnly = true; // Поле ID только для чтения
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string fullName = fullNameTextBox.Text.Trim(); // Удаляем лишние пробелы
            Address address = new Address();

            // Проверка на пустое имя
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Полное имя не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Customer newCustomer = new Customer(fullName, address);
                items.Add(newCustomer);
                UpdateListBox();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении клиента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateListBox()
        {
            CustomerslistBox.DataSource = null; // Сбрасываем источник данных
            CustomerslistBox.DataSource = items; // Устанавливаем новый источник данных
            CustomerslistBox.DisplayMember = "Display"; // Указываем, какое свойство отображать
        }

        private void ClearFields()
        {
            fullNameTextBox.Clear(); // Очищаем текстовое поле имени
            addressControl.Address = new Address(); // Очищаем AddressControl
        }
    }
}
