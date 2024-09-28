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
    /// <summary>
    /// Элемент управления для работы со списком товаров.
    /// Позволяет добавлять, удалять и отображать товары.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список элементов класса <see cref="Item"/>
        /// </summary>
        private List<Item> items = new List<Item>();

        /// <summary>
        /// Переменная класса <see cref="ValueValidator"/>, хранящего метод валидации строк
        /// </summary>
        private ValueValidator validator = new ValueValidator();

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="ItemsTab"/> и настраивает события.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            IDfield.ReadOnly = true;
            comboBoxCategories.DataSource = Enum.GetValues(typeof(Category));

            // Привязка событий
            nameField.Leave += nameField_Leave;
            descriptionField.Leave += descriptionField_Leave;
            costField.Leave += costField_Leave;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            comboBoxCategories.SelectedIndexChanged += comboBoxCategories_SelectedIndexChanged;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string name = nameField.Text;
            string info = descriptionField.Text;
            
            double cost;

            try
            {
                if (!double.TryParse(costField.Text, out cost) || !IsCostValid(cost))
                {
                    throw new ArgumentException("Стоимость должна быть больше 0 и меньше 100000.");
                }
                Category category = (Category)comboBoxCategories.SelectedItem;
                Item newItem = new Item(name, info, cost,category);
                items.Add(newItem);
                UpdateListBox();
                ClearFields();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
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
                comboBoxCategories.SelectedItem = selectedItem.Category;
            }
        }

        /// <summary>
        /// Обновляет отображаемый список товаров в элементе управления.
        /// </summary>
        private void UpdateListBox()
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = items;
            ItemsListBox.DisplayMember = "Display";
        }

        /// <summary>
        /// Очищает все поля ввода.
        /// </summary>
        private void ClearFields()
        {
            IDfield.Clear();
            nameField.Clear();
            descriptionField.Clear();
            costField.Clear();
            comboBoxCategories.SelectedIndex = -1;
        }

        private void nameField_Leave(object sender, EventArgs e)
        {
            ValidateName();
        }
        private void descriptionField_Leave(object sender, EventArgs e)
        {
            ValidateInfo();
        }
        private void costField_Leave(object sender, EventArgs e)
        {
            ValidateCost();
        }

        /// <summary>
        /// Проверяет корректность введенного имени товара.
        /// </summary>
        private void ValidateName()
        {
            try
            {
                validator.AssertStringOnLength(nameField.Text, 200, nameof(nameField));
                nameField.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                nameField.BackColor = System.Drawing.Color.Red;
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Проверяет корректность введенной информации о товаре(описании).
        /// </summary>
        private void ValidateInfo()
        {
            try
            {
                validator.AssertStringOnLength(descriptionField.Text, 1000, nameof(descriptionField));
                descriptionField.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                descriptionField.BackColor = System.Drawing.Color.Red;
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Проверяет корректность введенной стоимости товара.
        /// </summary>
        private void ValidateCost()
        {
            try
            {
                double costValue;
                if (!double.TryParse(costField.Text, out costValue) || !IsCostValid(costValue))
                {
                    throw new ArgumentException("Стоимость должна быть больше 0 и меньше 100000.");
                }
                costField.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                costField.BackColor = System.Drawing.Color.Red;
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Проверяет, находится ли стоимость в допустимых пределах (больше 0 и меньше 100000).
        /// </summary>
        /// <param name="value">Стоимость для проверки.</param>
        /// <returns>True, если стоимость допустима; иначе False.</returns>
        private bool IsCostValid(double value)
        {
            return value > 0.0 && value < 100000.0;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void description_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void costField_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is Item selectedItem && comboBoxCategories.SelectedItem is Category selectedCategory)
            {
                selectedItem.Category = selectedCategory;
            }
        }
    }
}

//namespace ObjectOrientedPractics.View.ItemsTab
//{
//    public partial class ItemsTab : UserControl
//    {
//        private List<Item> items = new List<Item>();
//        private ValueValidator validator = new ValueValidator();

//        public ItemsTab()
//        {
//            InitializeComponent();
//            IDfield.ReadOnly = true;

//            // Привязка событий
//            nameField.Leave += nameField_Leave;
//            descriptionField.Leave += descriptionField_Leave;
//            costField.Leave += costField_Leave;
//        }

//        private void Add_Click(object sender, EventArgs e)
//        {
//            string name = nameField.Text;
//            string info = descriptionField.Text;
//            double cost;

//            try
//            {
//                if (!double.TryParse(costField.Text, out cost) || !IsCostValid(cost))
//                {
//                    throw new ArgumentException("Стоимость должна быть больше 0 и меньше 100000.");
//                }

//                Item newItem = new Item(name, info, cost);
//                items.Add(newItem);
//                UpdateListBox();
//                ClearFields();
//            }
//            catch (ArgumentException ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//        }

//        private void Remove_Click(object sender, EventArgs e)
//        {
//            if (ItemsListBox.SelectedItem is Item selectedItem)
//            {
//                items.Remove(selectedItem);
//                UpdateListBox();
//                ClearFields();
//            }
//            else
//            {
//                MessageBox.Show("Выберите товар для удаления.");
//            }
//        }

//        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            if (ItemsListBox.SelectedItem is Item selectedItem)
//            {
//                IDfield.Text = selectedItem.Id.ToString();
//                nameField.Text = selectedItem.Name;
//                descriptionField.Text = selectedItem.Info;
//                costField.Text = selectedItem.Cost.ToString();
//            }
//        }

//        private void UpdateListBox()
//        {
//            ItemsListBox.DataSource = null;
//            ItemsListBox.DataSource = items;
//            ItemsListBox.DisplayMember = "Display";
//        }

//        private void ClearFields()
//        {
//            IDfield.Clear();
//            nameField.Clear();
//            descriptionField.Clear();
//            costField.Clear();
//        }

//        private void nameField_Leave(object sender, EventArgs e) { ValidateName(); }
//        private void descriptionField_Leave(object sender, EventArgs e) { ValidateInfo(); }
//        private void costField_Leave(object sender, EventArgs e) { ValidateCost(); }

//        private void ValidateName()
//        {
//            try
//            {
//                validator.AssertStringOnLength(nameField.Text, 50, nameof(nameField));
//                nameField.BackColor = System.Drawing.Color.White;
//            }
//            catch (ArgumentException ex)
//            {
//                nameField.BackColor = System.Drawing.Color.Red;
//                MessageBox.Show(ex.Message);
//            }
//        }

//        private void ValidateInfo()
//        {
//            try
//            {
//                validator.AssertStringOnLength(descriptionField.Text, 200, nameof(descriptionField));
//                descriptionField.BackColor = System.Drawing.Color.White;
//            }
//            catch (ArgumentException ex)
//            {
//                descriptionField.BackColor = System.Drawing.Color.Red;
//                MessageBox.Show(ex.Message);
//            }
//        }

//        private void ValidateCost()
//        {
//            try
//            {
//                double costValue;
//                if (!double.TryParse(costField.Text, out costValue) || !IsCostValid(costValue))
//                {
//                    throw new ArgumentException("Стоимость должна быть больше 0 и меньше 100000.");
//                }
//                costField.BackColor = System.Drawing.Color.White;
//            }
//            catch (ArgumentException ex)
//            {
//                costField.BackColor = System.Drawing.Color.Red;
//                MessageBox.Show(ex.Message);
//            }
//        }

//        private bool IsCostValid(double value) => value > 0.0 && value < 100000.0;
//        private void UpdateListBox()
//        {
//            ItemsListBox.DataSource = null;
//            ItemsListBox.DataSource = items;
//            ItemsListBox.DisplayMember = "Display";
//        }

//        private void ClearFields()
//        {
//            IDfield.Clear();
//            nameField.Clear();
//            descriptionField.Clear();
//            costField.Clear();
//        }


//        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        private void groupBox1_Enter(object sender, EventArgs e)
//        {

//        }

//        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
//        {

//        }
//        private void label2_Click(object sender, EventArgs e)
//        {

//        }

//        private void richTextBox2_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void label3_Click(object sender, EventArgs e)
//        {

//        }

//        private void richTextBox1_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void label4_Click(object sender, EventArgs e)
//        {

//        }

//        private void IDfield_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
//        {

//        }


//        private void costField_TextChanged(object sender, EventArgs e)
//        {

//        }
//    }
//}
//    }
//}


