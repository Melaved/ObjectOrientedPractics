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

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {

        private Address _address = new Address();


        public AddressControl()
        {
            InitializeComponent();

            UpdateUI();
        }

        public Address Address
        {
            get
            {

                return _address;
            }
            set
            {

                _address = value ?? new Address();
                UpdateUI();
            }
        }
        public void UpdateUI()
        {
            postIndexTextBox.Text = _address.Index.ToString();
            countryTextBox.Text = _address.Country;
            cityTextBox.Text = _address.City;
            streetTextBox.Text = _address.Street;
            buildingTextBox.Text = _address.Building;
            apartmentTextBox.Text = _address.Apartment;
        }

        private void streetTextBox_TextChanged(object sender, EventArgs e)
        {
            _address.Street = streetTextBox.Text;

        }


        private void countryTextBox_TextChanged(object sender, EventArgs e)
        {
            _address.Country = countryTextBox.Text;

        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            _address.City = cityTextBox.Text;

        }

        private void postIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(postIndexTextBox.Text, out int index))
            {
                _address.Index = index;
            }
            else
            {

                MessageBox.Show("Введите корректный индекс.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                postIndexTextBox.Clear();
                _address.Index = 0;
            }

        }

        private void buildingTextBox_TextChanged(object sender, EventArgs e)
        {
            _address.Building = buildingTextBox.Text;

        }

        private void apartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            _address.Apartment = apartmentTextBox.Text;

        }
        public void ClearFields()
        {
            postIndexTextBox.Text = "";
            countryTextBox.Text = "";
            cityTextBox.Text = "";
            streetTextBox.Text = "";
            buildingTextBox.Text = "";
            apartmentTextBox.Text = "";

            _address = new Address(0, "", "", "", "", "");
            
        }

    }
}


//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using TextBox = System.Windows.Forms.TextBox;


//namespace ObjectOrientedPractics.View.Controls
//{
//    public partial class AddressControl : UserControl
//    {

//        private Address _address = new Address();

//        private ListBox _targetListBox;
//        public AddressControl(ListBox targetListBox)
//        {
//            InitializeComponent();
//            _targetListBox = targetListBox;
//            UpdateUI();
//        }

//        public Address Address
//        {
//            get
//            {
//                ValidateAllFields();
//                return _address;
//            }
//            set
//            {

//                _address = value ?? new Address();
//                UpdateUI();
//            }
//        }
//        private void UpdateUI()
//        {
//            postIndexTextBox.Text = _address.Index.ToString();
//            countryTextBox.Text = _address.Country;
//            cityTextBox.Text = _address.City;
//            streetTextBox.Text = _address.Street;
//            buildingTextBox.Text = _address.Building;
//            apartmentTextBox.Text = _address.Apartment;

//            ClearValidationErrors();
//        }

//        private void streetTextBox_TextChanged(object sender, EventArgs e)
//        {
//            _address.Street = streetTextBox.Text;
//            ValidateStreet();
//            SendAddressToListBox();

//        }


//        private void countryTextBox_TextChanged(object sender, EventArgs e)
//        {
//            _address.Country = countryTextBox.Text;
//            ValidateCountry();
//            SendAddressToListBox();

//        }

//        private void cityTextBox_TextChanged(object sender, EventArgs e)
//        {
//            _address.City = cityTextBox.Text;
//            ValidateCity();
//            SendAddressToListBox();

//        }

//        private void postIndexTextBox_TextChanged(object sender, EventArgs e)
//        {
//            if (int.TryParse(postIndexTextBox.Text, out int index) && index >= 100000 && index <= 999999)
//            {
//                _address.Index = index;
//                ClearValidationError(postIndexTextBox);
//            }
//            else
//            {
//                SetValidationError(postIndexTextBox, "Почтовый индекс должен быть шестизначным числом.");
//            }
//            SendAddressToListBox();

//        }

//        private void buildingTextBox_TextChanged(object sender, EventArgs e)
//        {
//            _address.Building = buildingTextBox.Text;
//            ValidateBuilding();
//            SendAddressToListBox();
//        }

//        private void apartmentTextBox_TextChanged(object sender, EventArgs e)
//        {
//            _address.Apartment = apartmentTextBox.Text;
//            ValidateApartment();
//            SendAddressToListBox();
//        }

//        private void ValidateCountry()
//        {
//            if (string.IsNullOrEmpty(_address.Country) || _address.Country.Length > 50)
//            {
//                SetValidationError(countryTextBox, "Страна не может быть пустой и должна быть не более 50 символов.");
//            }
//            else
//            {
//                ClearValidationError(countryTextBox);
//            }
//        }

//        private void ValidateCity()
//        {
//            if (string.IsNullOrEmpty(_address.City) || _address.City.Length > 50)
//            {
//                SetValidationError(cityTextBox, "Город не может быть пустым и должен быть не более 50 символов.");
//            }
//            else
//            {
//                ClearValidationError(cityTextBox);
//            }
//        }

//        private void ValidateStreet()
//        {
//            if (string.IsNullOrEmpty(_address.Street) || _address.Street.Length > 100)
//            {
//                SetValidationError(streetTextBox, "Улица не может быть пустой и должна быть не более 100 символов.");
//            }
//            else
//            {
//                ClearValidationError(streetTextBox);
//            }
//        }

//        private void ValidateBuilding()
//        {
//            if (string.IsNullOrEmpty(_address.Building) || _address.Building.Length > 10)
//            {
//                SetValidationError(buildingTextBox, "Номер дома не может быть пустым и должен быть не более 10 символов.");
//            }
//            else
//            {
//                ClearValidationError(buildingTextBox);
//            }
//        }

//        private void ValidateApartment()
//        {
//            if (_address.Apartment != null && _address.Apartment.Length > 10)
//            {
//                SetValidationError(apartmentTextBox, "Номер квартиры не может быть более 10 символов.");
//            }
//            else
//            {
//                ClearValidationError(apartmentTextBox);
//            }
//        }

//        // Валидация всех полей
//        private void ValidateAllFields()
//        {

//            ValidateCountry();
//            ValidateCity();
//            ValidateStreet();
//            ValidateBuilding();
//            ValidateApartment();
//        }

//        // Методы для установки и очистки ошибок валидации
//        private void SetValidationError(TextBox textBox, string errorMessage)
//        {
//            textBox.BackColor = Color.Pink;

//        }

//        private void ClearValidationError(TextBox textBox)
//        {
//            textBox.BackColor = Color.White;

//        }

//        private void ClearValidationErrors()
//        {
//            ClearValidationError(postIndexTextBox);
//            ClearValidationError(countryTextBox);
//            ClearValidationError(cityTextBox);
//            ClearValidationError(streetTextBox);
//            ClearValidationError(buildingTextBox);
//            ClearValidationError(apartmentTextBox);
//        }

//        // Метод для отправки данных в ListBox
//        private void SendAddressToListBox()
//        {
//            if (_targetListBox != null)
//            {
//                _targetListBox.Items.Add($"{_address.Index} {_address.Country}, {_address.City}, ул. {_address.Street}, д. {_address.Building}, кв. {_address.Apartment}");
//            }
//        }
//    }
//}