using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.ItemsTab
{
    public partial class ItemsTab : UserControl
    {
        private List<Item> items = new List<Item>();

        public ItemsTab()
        {
            InitializeComponent();
            IDfield.ReadOnly = true;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string name = nameField.Text;
            string info = descriptionField.Text; 
            double cost;

            if (double.TryParse(costField.Text, out cost))
            {
                Item newItem = new Item(name, info, cost);
                items.Add(newItem);
                UpdateListBox();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Введите корректную стоимость.");
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is Item selectedItem)
            {
                items.Remove(selectedItem);
                UpdateListBox();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Выберите товар для удаления.");
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is Item selectedItem)
            {

                IDfield.Text = selectedItem.Id.ToString();
                nameField.Text = selectedItem.Name;
                descriptionField.Text = selectedItem.Info; 
                costField.Text = selectedItem.Cost.ToString(); 
            }
        }

        private void UpdateListBox()
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = items;
            ItemsListBox.DisplayMember = "Display"; 
        }

        private void ClearFields()
        {
            IDfield.Clear();
            nameField.Clear();
            descriptionField.Clear();
            costField.Clear();
        }
    

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {
 
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void IDfield_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        private void costField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
