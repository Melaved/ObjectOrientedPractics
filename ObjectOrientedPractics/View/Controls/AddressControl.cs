using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {

        private ListBox _targetListBox;
        private Address _address = new Address();

        public AddressControl(ListBox targetListBox)
        {
            InitializeComponent();
            _targetListBox = targetListBox;
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
        private void UpdateUI()
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
            _address.Index = _address.Index;
        }

        private void buildingTextBox_TextChanged(object sender, EventArgs e)
        {
            _address.Building = buildingTextBox.Text;
        }

        private void apartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            _address.Apartment = apartmentTextBox.Text;
        }
    }
}
