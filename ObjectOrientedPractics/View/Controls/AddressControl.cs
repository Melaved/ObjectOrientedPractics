//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Net;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace ObjectOrientedPractics.View.Controls
//{
//    public partial class AddressControl : UserControl
//    {

//        private Address _address = new Address();

//        /// <summary>
//        /// Переменная класса <see cref="ValueValidator"/>, хранящего метод валидации строк
//        /// </summary>
//        private ValueValidator _validator = new ValueValidator();

//        public AddressControl()
//        {
//            InitializeComponent();
//            _address = new Address(0, "", "", "", "", "");
//            UpdateUI();
//        }

//        public Address Address
//        {
//            get
//            {

//                return _address;
//            }
//            set
//            {

//                _address = value ?? new Address();
//                UpdateUI();
//            }
//        }
//        public void UpdateUI()
//        {
//            _address = new Address(_address.Index, _address.Country, _address.City,
//                              _address.Street, _address.Building, _address.Apartment);
//            postIndexTextBox.Text = _address.Index.ToString();
//            countryTextBox.Text = _address.Country;
//            cityTextBox.Text = _address.City;
//            streetTextBox.Text = _address.Street;
//            buildingTextBox.Text = _address.Building;
//            apartmentTextBox.Text = _address.Apartment;
//        }

//        private void streetTextBox_TextChanged(object sender, EventArgs e)
//        {
//            _address.Street = streetTextBox.Text;

//        }


//        private void countryTextBox_TextChanged(object sender, EventArgs e)
//        {
//            _address.Country = countryTextBox.Text;

//        }

//        private void cityTextBox_TextChanged(object sender, EventArgs e)
//        {
//            _address.City = cityTextBox.Text;

//        }

//        private void postIndexTextBox_TextChanged(object sender, EventArgs e)
//        {
//            if (int.TryParse(postIndexTextBox.Text, out int index))
//            {
//                _address.Index = index;
//            }
//            else
//            {
//                postIndexTextBox.BackColor = Color.Red;
//            }
//            //ValidateIndex();
//        }

//        private void buildingTextBox_TextChanged(object sender, EventArgs e)
//        {
//            _address.Building = buildingTextBox.Text;

//        }

//        private void apartmentTextBox_TextChanged(object sender, EventArgs e)
//        {
//            _address.Apartment = apartmentTextBox.Text;

//        }


//        public void ClearFields()
//        {
//            postIndexTextBox.Text = "";
//            countryTextBox.Text = "";
//            cityTextBox.Text = "";
//            streetTextBox.Text = "";
//            buildingTextBox.Text = "";
//            apartmentTextBox.Text = "";

//            _address = new Address(0, "", "", "", "", "");

//        }


//        private void cityTextBox_Leave(object sender, EventArgs e)
//        {
//            ValidateCity();
//        }

//        private void streetTextBox_Leave(object sender, EventArgs e)
//        {
//            ValidateStreet();
//        }

//        private void apartmentTextBox_Leave(object sender, EventArgs e)
//        {
//            ValidateApartment();
//        }

//        private void buildingTextBox_Leave(object sender, EventArgs e)
//        {
//            ValidateBuilding();
//        }

//        private void countryTextBox_Leave(object sender, EventArgs e)
//        {
//            ValidateCountry();
//        }

//        private void postIndexTextBox_Leave(object sender, EventArgs e)
//        {
//            ValidateIndex();
//        }

//        private void ValidateIndex()
//        {
//            if (int.TryParse(postIndexTextBox.Text, out int postIndexValue))
//            {
//                try
//                {
//                    _validator.AssertNumberOnIntValue(postIndexValue, 100000, 999999, postIndexValue.ToString());
//                    postIndexTextBox.BackColor = System.Drawing.Color.White;
//                }
//                catch (ArgumentException ex)
//                {
//                    postIndexTextBox.BackColor = System.Drawing.Color.Red;
//                    MessageBox.Show(ex.Message);
//                }
//            }
//            else
//            {
//                postIndexTextBox.BackColor = System.Drawing.Color.Red;
//                MessageBox.Show("Пожалуйста, введите корректное числовое значение для индекса.");
//            }
//        }
//        private void ValidateCountry()
//        {
//            try
//            {
//                _validator.AssertStringOnLength(countryTextBox.Text, 50, nameof(countryTextBox));
//                countryTextBox.BackColor = System.Drawing.Color.White;
//            }
//            catch (ArgumentException ex)
//            {
//                countryTextBox.BackColor = System.Drawing.Color.Red;
//                MessageBox.Show(ex.Message);
//            }
//        }

//        private void ValidateCity()
//        {
//            try
//            {
//                _validator.AssertStringOnLength(cityTextBox.Text, 50, nameof(cityTextBox));
//                cityTextBox.BackColor = System.Drawing.Color.White;
//            }
//            catch (ArgumentException ex)
//            {
//                cityTextBox.BackColor = System.Drawing.Color.Red;
//                MessageBox.Show(ex.Message);
//            }
//        }

//        private void ValidateStreet()
//        {
//            try
//            {
//                _validator.AssertStringOnLength(streetTextBox.Text, 100, nameof(streetTextBox));
//                streetTextBox.BackColor = System.Drawing.Color.White;
//            }
//            catch (ArgumentException ex)
//            {
//                streetTextBox.BackColor = System.Drawing.Color.Red;
//                MessageBox.Show(ex.Message);
//            }
//        }

//        private void ValidateBuilding()
//        {
//            try
//            {
//                _validator.AssertStringOnLength(buildingTextBox.Text, 10, nameof(buildingTextBox));
//                buildingTextBox.BackColor = System.Drawing.Color.White;
//            }
//            catch (ArgumentException ex)
//            {
//                buildingTextBox.BackColor = System.Drawing.Color.Red;
//                MessageBox.Show(ex.Message);
//            }
//        }

//        private void ValidateApartment()
//        {
//            try
//            {
//                _validator.AssertStringOnLength(apartmentTextBox.Text, 10, nameof(apartmentTextBox));
//                apartmentTextBox.BackColor = System.Drawing.Color.White;
//            }
//            catch (ArgumentException ex)
//            {
//                apartmentTextBox.BackColor = System.Drawing.Color.Red;
//                MessageBox.Show(ex.Message);
//            }
//        }
//    }
//}


//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Net;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace ObjectOrientedPractics.View.Controls
//{
//    public partial class AddressControl : UserControl
//    {

//        private Address _address = new Address();

//        /// <summary>
//        /// Переменная класса <see cref="ValueValidator"/>, хранящего метод валидации строк
//        /// </summary>
//        private ValueValidator _validator = new ValueValidator();

//        public TextBox PostIndexTextBox { get; private set; }
//        public TextBox CountryTextBox { get; private set; }
//        public TextBox CityTextBox { get; private set; }
//        public TextBox StreetTextBox { get; private set; }
//        public TextBox BuildingTextBox { get; private set; }
//        public TextBox ApartmentTextBox { get; private set; }

//        public AddressControl()
//        {
//            InitializeComponent();
//            _address = new Address(0, "", "", "", "", "");
//            UpdateUI();

//            Инициализируем свойства TextBox
//            PostIndexTextBox = postIndexTextBox;
//            CountryTextBox = countryTextBox;
//            CityTextBox = cityTextBox;
//            StreetTextBox = streetTextBox;
//            BuildingTextBox = buildingTextBox;
//            ApartmentTextBox = apartmentTextBox;

//            // Подписываемся на события TextChanged для каждого TextBox
//            PostIndexTextBox.TextChanged += PostIndexTextBox_TextChanged;
//            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
//            CityTextBox.TextChanged += CityTextBox_TextChanged;
//            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
//            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
//            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
//        }

//        public Address Address
//        {
//            get
//            {

//                return _address;
//            }
//            set
//            {

//                _address = value ?? new Address();
//                UpdateUI();
//            }
//        }
//        public void UpdateUI()
//        {
//            _address = new Address(_address.Index, _address.Country, _address.City, _address.Street, _address.Building, _address.Apartment);
//            PostIndexTextBox.Text = _address.Index.ToString();
//            CountryTextBox.Text = _address.Country;
//            CityTextBox.Text = _address.City;
//            StreetTextBox.Text = _address.Street;
//            BuildingTextBox.Text = _address.Building;
//            ApartmentTextBox.Text = _address.Apartment;
//        }

//        // Обработчики событий TextChanged
//        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
//        {
//            if (int.TryParse(PostIndexTextBox.Text, out int index))
//            {
//                _address.Index = index;
//                PostIndexTextBox.BackColor = Color.White; // Убираем красную подсветку
//            }
//            else
//            {
//                PostIndexTextBox.BackColor = Color.Red; // Устанавливаем красную подсветку
//            }
//        }

//        private void CountryTextBox_TextChanged(object sender, EventArgs e)
//        {
//            _address.Country = CountryTextBox.Text;
//        }

//        private void CityTextBox_TextChanged(object sender, EventArgs e)
//        {
//            _address.City = CityTextBox.Text;
//        }

//        private void StreetTextBox_TextChanged(object sender, EventArgs e)
//        {
//            _address.Street = StreetTextBox.Text;
//        }

//        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
//        {
//            _address.Building = BuildingTextBox.Text;
//        }

//        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
//        {
//            _address.Apartment = ApartmentTextBox.Text;
//        }


//        public void ClearFields()
//        {
//            postIndexTextBox.Text = "";
//            countryTextBox.Text = "";
//            cityTextBox.Text = "";
//            streetTextBox.Text = "";
//            buildingTextBox.Text = "";
//            apartmentTextBox.Text = "";

//            _address = new Address(0, "", "", "", "", "");

//        }


//        private void cityTextBox_Leave(object sender, EventArgs e)
//        {
//            ValidateCity();
//        }

//        private void streetTextBox_Leave(object sender, EventArgs e)
//        {
//            ValidateStreet();
//        }

//        private void apartmentTextBox_Leave(object sender, EventArgs e)
//        {
//            ValidateApartment();
//        }

//        private void buildingTextBox_Leave(object sender, EventArgs e)
//        {
//            ValidateBuilding();
//        }

//        private void countryTextBox_Leave(object sender, EventArgs e)
//        {
//            ValidateCountry();
//        }

//        private void postIndexTextBox_Leave(object sender, EventArgs e)
//        {
//            ValidateIndex();
//        }

//        private void ValidateIndex()
//        {
//            if (int.TryParse(postIndexTextBox.Text, out int postIndexValue))
//            {
//                try
//                {
//                    _validator.AssertNumberOnIntValue(postIndexValue, 100000, 999999, postIndexValue.ToString());
//                    postIndexTextBox.BackColor = System.Drawing.Color.White;
//                }
//                catch (ArgumentException ex)
//                {
//                    postIndexTextBox.BackColor = System.Drawing.Color.Red;
//                    MessageBox.Show(ex.Message);
//                }
//            }
//            else
//            {
//                postIndexTextBox.BackColor = System.Drawing.Color.Red;
//                MessageBox.Show("Пожалуйста, введите корректное числовое значение для индекса.");
//            }
//        }
//        private void ValidateCountry()
//        {
//            try
//            {
//                _validator.AssertStringOnLength(countryTextBox.Text, 50, nameof(countryTextBox));
//                countryTextBox.BackColor = System.Drawing.Color.White;
//            }
//            catch (ArgumentException ex)
//            {
//                countryTextBox.BackColor = System.Drawing.Color.Red;
//                MessageBox.Show(ex.Message);
//            }
//        }

//        private void ValidateCity()
//        {
//            try
//            {
//                _validator.AssertStringOnLength(cityTextBox.Text, 50, nameof(cityTextBox));
//                cityTextBox.BackColor = System.Drawing.Color.White;
//            }
//            catch (ArgumentException ex)
//            {
//                cityTextBox.BackColor = System.Drawing.Color.Red;
//                MessageBox.Show(ex.Message);
//            }
//        }

//        private void ValidateStreet()
//        {
//            try
//            {
//                _validator.AssertStringOnLength(streetTextBox.Text, 100, nameof(streetTextBox));
//                streetTextBox.BackColor = System.Drawing.Color.White;
//            }
//            catch (ArgumentException ex)
//            {
//                streetTextBox.BackColor = System.Drawing.Color.Red;
//                MessageBox.Show(ex.Message);
//            }
//        }

//        private void ValidateBuilding()
//        {
//            try
//            {
//                _validator.AssertStringOnLength(buildingTextBox.Text, 10, nameof(buildingTextBox));
//                buildingTextBox.BackColor = System.Drawing.Color.White;
//            }
//            catch (ArgumentException ex)
//            {
//                buildingTextBox.BackColor = System.Drawing.Color.Red;
//                MessageBox.Show(ex.Message);
//            }
//        }

//        private void ValidateApartment()
//        {
//            try
//            {
//                _validator.AssertStringOnLength(apartmentTextBox.Text, 10, nameof(apartmentTextBox));
//                apartmentTextBox.BackColor = System.Drawing.Color.White;
//            }
//            catch (ArgumentException ex)
//            {
//                apartmentTextBox.BackColor = System.Drawing.Color.Red;
//                MessageBox.Show(ex.Message);
//            }
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {

        Address _address = new Address();

        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public AddressControl()
        {
            InitializeComponent();
            _address = new Address();   
        }


    }
}


    
    