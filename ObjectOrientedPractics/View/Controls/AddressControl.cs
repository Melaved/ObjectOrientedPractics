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

        private Address _address = new Address();

       public Address OurAddress
        { 
            get
            { 
                return _address; 
            } 
            set
            { 
                _address = value ?? new Address();
            }
        }  

        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Updates information in TextBoxes.
        /// </summary>
        public void SelelctedTextBoxs(Address address)
        {
            postIndexTextBox.Text = address.Index.ToString();
            countryTextBox.Text = address.Country.ToString();
            cityTextBox.Text = address.City.ToString();
            streetTextBox.Text = address.Street.ToString();
            buildingTextBox.Text = address.Building.ToString();
            apartmentTextBox.Text = address.Apartment.ToString();
        }

        /// <summary>
        /// Clears information in TextBoxes.
        /// </summary>
        public void ClearTextBoxes()
        {
            postIndexTextBox.Clear();
            countryTextBox.Clear();
            cityTextBox.Clear();
            streetTextBox.Clear();
            buildingTextBox.Clear();
            apartmentTextBox.Clear();
        }

        /// <summary>
        /// Adds information from TextBoxes.                        
        /// </summary>
        public  Address AddInfoFromTextBox()
        {
            int index = int.Parse(postIndexTextBox.Text);
            string country = countryTextBox.Text;
            string city = cityTextBox.Text;
            string street = streetTextBox.Text;
            string building = buildingTextBox.Text;
            string apartment = apartmentTextBox.Text;

            return new Address(index, country, city, street, building, apartment);
        }

        /// <summary>
        /// Edits information from TextBoxes.                     
        /// </summary>
        private void EditTextBoxes(Customer customer)
        {
            customer.CustomerAddress.Index = int.Parse(postIndexTextBox.Text);
            customer.CustomerAddress.Country = countryTextBox.Text;
            customer.CustomerAddress.City = cityTextBox.Text;
            customer.CustomerAddress.Street = streetTextBox.Text;
            customer.CustomerAddress.Building = buildingTextBox.Text;
            customer.CustomerAddress.Apartment = apartmentTextBox.Text;
        }

        private void postIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Index = int.Parse(postIndexTextBox.Text);
                postIndexTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                if (postIndexTextBox.Text != "")
                {
                    postIndexTextBox.BackColor = Color.LightPink;
                }
            }
        }

        private void countryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Country = countryTextBox.Text;
                countryTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                countryTextBox.BackColor = Color.LightPink;
            }
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.City = cityTextBox.Text;
                cityTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                cityTextBox.BackColor = Color.LightPink;
            }
        }

        private void streetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Street = streetTextBox.Text;
                streetTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                streetTextBox.BackColor = Color.LightPink;
            }
        }

        private void buildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Building = buildingTextBox.Text;
                buildingTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                buildingTextBox.BackColor = Color.LightPink;
            }
        }

        private void apartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Apartment = apartmentTextBox.Text;
                apartmentTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                apartmentTextBox.BackColor = Color.LightPink;
            }
        }
    }
}


