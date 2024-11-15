using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model;
using System.Net;

namespace ObjectOrientedPractics.View.AdditionalForms
{

    public partial class DiscountPanel : Form
    {
       
        public Category Category { get; set; }

        
        public Customer Customer { get; } = new Customer();

        
        public DiscountPanel(Customer customer)
        {
            InitializeComponent();
            Customer = customer;
            LoadCategoryComboBox();
        }

        
        private void LoadCategoryComboBox()
        {
            var customerCategories = Customer.Discounts
                .OfType<PercentDiscount>()
                .Select(discount => discount.Category)
                .Distinct()
                .ToList();

            var dataCategories = Enum.GetValues(typeof(Category))
                .Cast<Category>()
                .ToList()
                .Except(customerCategories)
                .ToList();

            CategoryComboBox.DataSource = dataCategories;
        }


        private void OkDiscountsButton_Click(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedItem != null)
            {
                Category = (Category)CategoryComboBox.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OkButton.Enabled = CategoryComboBox.SelectedIndex >= 0;
        }
    }
}