using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Пользовательский элемент управления, представляющий адрес с полями для ввода и отображения.
    /// Позволяет управлять данными адреса и обновлять их отображение на основе ввода пользователя.
    /// </summary>
    public partial class AddressControl : UserControl
    {

        /// <summary>
        /// Поле, которое хранит адресс.
        /// </summary>
        Address _address;

        /// <summary>
        /// Флаг для корректного обновления полей адреса.
        /// </summary>
        public bool IsUpdatingFieldFlag = false;

        /// <summary>
        /// Хранит данные нового адресса.
        /// </summary>
        public AddressControl NewAddress;

        /// <summary>
        /// Возвращает и задает объект <see cref="Address"/>.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AddressControl"/>
        /// и устанавливает начальное значение для <see cref="Address"/>.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
            Address = new Address();
        }



        private void postIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(postIndexTextBox.Text, out int index) || index < 100000 || index > 999999)
            {
                postIndexTextBox.BackColor = Color.Pink;
                
                return;
            }

            try
            {
                postIndexTextBox.BackColor = Color.White;
                NewAddress.Address.Index = index;
            }
            catch (ArgumentException error)
            {
                
                postIndexTextBox.BackColor = Color.Pink;
            }
        }


        private void countryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == false)
            {
                try
                {

                    countryTextBox.BackColor = Color.White;

                    NewAddress.Address.Country = countryTextBox.Text;
                }
                catch (ArgumentException error)
                {
                   
                    countryTextBox.BackColor = Color.Pink;
                }
            }

        }


        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == false)
            {
                try
                {
                    cityTextBox.BackColor = Color.White;
                    NewAddress.Address.City = cityTextBox.Text;
                }
                catch (ArgumentException error)
                {

                    cityTextBox.BackColor = Color.Pink;
                }
            }
        }


        private void streetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == false)
            {
                try
                {
                    streetTextBox.BackColor = Color.White;
                    NewAddress.Address.Street = streetTextBox.Text;
                }
                catch (ArgumentException error)
                {
                    
                    streetTextBox.BackColor = Color.Pink;
                }
            }
        }

        private void buildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == false)
            {
                try
                {
                    buildingTextBox.BackColor = Color.White;
                    NewAddress.Address.Building = buildingTextBox.Text;
                }
                catch (ArgumentException error)
                {
                    buildingTextBox.BackColor = Color.Pink;
                }
            }
        }

        private void apartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsUpdatingFieldFlag == false)
            {
                try
                {
                    apartmentTextBox.BackColor = Color.White;
                    NewAddress.Address.Apartment = apartmentTextBox.Text;
                }
                catch (ArgumentException error)
                {
                    apartmentTextBox.BackColor = Color.Pink;
                }
            }
        }

        /// <summary>
        /// Очистка текстовых полей.
        /// </summary>
        public void ClearTextBox()
        {
            postIndexTextBox.Clear();
            countryTextBox.Clear();
            cityTextBox.Clear();
            streetTextBox.Clear();
            buildingTextBox.Clear();
            apartmentTextBox.Clear();
            postIndexTextBox.BackColor = Color.White;
        }




        /// <summary>
        /// При выборе обьекта в листбокс показывает текстбоксы <see cref="Address"/>.
        /// </summary>
        public void UpdateData(Address Address)
        {


            NewAddress.Address = Address;

            postIndexTextBox.Text = NewAddress.Address.Index.ToString();
            countryTextBox.Text = NewAddress.Address.Country.ToString();
            cityTextBox.Text = NewAddress.Address.City.ToString();
            streetTextBox.Text = NewAddress.Address.Street.ToString();
            buildingTextBox.Text = NewAddress.Address.Building.ToString();
            apartmentTextBox.Text = NewAddress.Address.Apartment.ToString();

        }

        /// <summary>
        /// Инициализируем обьект адресс на основе текущих значениях TextBox/
        /// </summary>
        public Address GiveValues()
        {
            return new Address(int.Parse(postIndexTextBox.Text),
                countryTextBox.Text, cityTextBox.Text, streetTextBox.Text, buildingTextBox.Text, apartmentTextBox.Text);
        }


        /// <summary>
        /// Проверяет, является ли адрес пустым или отсутствующим.
        /// </summary>
        public bool AddressIsNullOrEmpty()
        {
            if (string.IsNullOrEmpty(postIndexTextBox.Text) ||
                string.IsNullOrEmpty(countryTextBox.Text) ||
                string.IsNullOrEmpty(cityTextBox.Text) ||
                string.IsNullOrEmpty(streetTextBox.Text) ||
                string.IsNullOrEmpty(buildingTextBox.Text) ||
                string.IsNullOrEmpty(apartmentTextBox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void AddressControl_Load(object sender, EventArgs e)
        {
            NewAddress = new AddressControl();
        }

        private void postIndexTextBox_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(postIndexTextBox.Text, out int postIndexValue))
            {
                try
                {
                    ValueValidator.AssertNumberOnValue(postIndexValue, 100000, 999999, "PostIndex");
                    postIndexTextBox.BackColor = System.Drawing.Color.White;
                }
                catch (ArgumentException ex)
                {
                    postIndexTextBox.BackColor = System.Drawing.Color.Red;
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                postIndexTextBox.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("Пожалуйста, введите корректное числовое значение для индекса.");
            }
        }

        private void countryTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnLength(countryTextBox.Text, 50, "Country");
                countryTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                countryTextBox.BackColor = System.Drawing.Color.Red;
                MessageBox.Show(ex.Message);
            }
        }

        private void cityTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnLength(cityTextBox.Text, 50, "City");
                cityTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                cityTextBox.BackColor = System.Drawing.Color.Red;
                MessageBox.Show(ex.Message);
            }
        }

        private void streetTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnLength(streetTextBox.Text, 100, "Street");
                streetTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                streetTextBox.BackColor = System.Drawing.Color.Red;
                MessageBox.Show(ex.Message);
            }
        }

        private void buildingTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnLength(buildingTextBox.Text, 10, "Building");
                buildingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                buildingTextBox.BackColor = System.Drawing.Color.Red;
                MessageBox.Show(ex.Message);
            }
        }

        private void apartmentTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                ValueValidator.AssertStringOnLength(apartmentTextBox.Text, 10, "Apartment");
                apartmentTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                apartmentTextBox.BackColor = System.Drawing.Color.Red;
                MessageBox.Show(ex.Message);
            }
        }
    }
}