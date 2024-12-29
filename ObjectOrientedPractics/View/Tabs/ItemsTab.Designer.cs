namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ItemsGroupBox = new GroupBox();
            SortByComboBox = new ComboBox();
            OrderByLabel = new Label();
            FindTextBox = new TextBox();
            FindLabel = new Label();
            groupBox1 = new GroupBox();
            RemoveButton = new Button();
            AddButton = new Button();
            ItemsListBox = new ListBox();
            groupBox2 = new GroupBox();
            CategoryComboBox = new ComboBox();
            label5 = new Label();
            DescriptionTextBox = new TextBox();
            label4 = new Label();
            NameTextBox = new TextBox();
            CostTextBox = new TextBox();
            IDTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ItemsGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Controls.Add(SortByComboBox);
            ItemsGroupBox.Controls.Add(OrderByLabel);
            ItemsGroupBox.Controls.Add(FindTextBox);
            ItemsGroupBox.Controls.Add(FindLabel);
            ItemsGroupBox.Controls.Add(groupBox1);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Dock = DockStyle.Left;
            ItemsGroupBox.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ItemsGroupBox.Location = new Point(0, 0);
            ItemsGroupBox.Margin = new Padding(4, 3, 4, 3);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Padding = new Padding(4, 3, 4, 3);
            ItemsGroupBox.Size = new Size(420, 695);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // SortByComboBox
            // 
            SortByComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SortByComboBox.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SortByComboBox.FormattingEnabled = true;
            SortByComboBox.Items.AddRange(new object[] { "Name", "Ascending Cost", "Down Cost" });
            SortByComboBox.Location = new Point(91, 732);
            SortByComboBox.Margin = new Padding(4, 5, 4, 5);
            SortByComboBox.Name = "SortByComboBox";
            SortByComboBox.Size = new Size(314, 29);
            SortByComboBox.TabIndex = 5;
            SortByComboBox.SelectedIndexChanged += SortByComboBox_SelectedIndexChanged;
            // 
            // OrderByLabel
            // 
            OrderByLabel.AutoSize = true;
            OrderByLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OrderByLabel.Location = new Point(11, 737);
            OrderByLabel.Margin = new Padding(4, 0, 4, 0);
            OrderByLabel.Name = "OrderByLabel";
            OrderByLabel.Size = new Size(77, 21);
            OrderByLabel.TabIndex = 4;
            OrderByLabel.Text = "Sort by: ";
            // 
            // FindTextBox
            // 
            FindTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FindTextBox.Location = new Point(94, 27);
            FindTextBox.Margin = new Padding(4, 5, 4, 5);
            FindTextBox.Name = "FindTextBox";
            FindTextBox.Size = new Size(311, 32);
            FindTextBox.TabIndex = 3;
            FindTextBox.TextChanged += FindTextBox_TextChanged;
            // 
            // FindLabel
            // 
            FindLabel.AutoSize = true;
            FindLabel.Location = new Point(11, 32);
            FindLabel.Margin = new Padding(4, 0, 4, 0);
            FindLabel.Name = "FindLabel";
            FindLabel.Size = new Size(67, 25);
            FindLabel.TabIndex = 2;
            FindLabel.Text = "Find:  ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RemoveButton);
            groupBox1.Controls.Add(AddButton);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(4, 537);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(412, 155);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // RemoveButton
            // 
            RemoveButton.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RemoveButton.Location = new Point(157, 23);
            RemoveButton.Margin = new Padding(4, 3, 4, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(149, 55);
            RemoveButton.TabIndex = 8;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddButton.Location = new Point(7, 23);
            AddButton.Margin = new Padding(4, 3, 4, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(141, 57);
            AddButton.TabIndex = 8;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 21;
            ItemsListBox.Location = new Point(7, 83);
            ItemsListBox.Margin = new Padding(4, 3, 4, 3);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(398, 298);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            ItemsListBox.DoubleClick += ItemsListBox_DoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(CategoryComboBox);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(DescriptionTextBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(NameTextBox);
            groupBox2.Controls.Add(CostTextBox);
            groupBox2.Controls.Add(IDTextBox);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(424, 3);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(449, 662);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selected Item";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(113, 145);
            CategoryComboBox.Margin = new Padding(4, 3, 4, 3);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(181, 33);
            CategoryComboBox.TabIndex = 9;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(9, 152);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 8;
            label5.Text = "Category:";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(21, 403);
            DescriptionTextBox.Margin = new Padding(4, 3, 4, 3);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(341, 227);
            DescriptionTextBox.TabIndex = 7;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(7, 363);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 21);
            label4.TabIndex = 6;
            label4.Text = "Description:";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(21, 248);
            NameTextBox.Margin = new Padding(4, 3, 4, 3);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(341, 107);
            NameTextBox.TabIndex = 5;
            NameTextBox.TextChanged += NameTextBox_TextChanged_1;
            // 
            // CostTextBox
            // 
            CostTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CostTextBox.Location = new Point(113, 90);
            CostTextBox.Margin = new Padding(4, 3, 4, 3);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(181, 32);
            CostTextBox.TabIndex = 4;
            CostTextBox.TextChanged += CostTextBox_TextChanged_1;
            // 
            // IDTextBox
            // 
            IDTextBox.Enabled = false;
            IDTextBox.Location = new Point(113, 47);
            IDTextBox.Margin = new Padding(4, 3, 4, 3);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(181, 32);
            IDTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(7, 213);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 2;
            label3.Text = "Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(7, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 1;
            label2.Text = "Cost: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(7, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 21);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(ItemsGroupBox);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(877, 695);
            Name = "ItemsTab";
            Size = new Size(877, 695);
            ItemsGroupBox.ResumeLayout(false);
            ItemsGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ItemsGroupBox;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private ListBox ItemsListBox;
        private TextBox CostTextBox;
        private TextBox IDTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox NameTextBox;
        private Button RemoveButton;
        private Button AddButton;
        private TextBox DescriptionTextBox;
        private ComboBox CategoryComboBox;
        private Label label5;
        private Label FindLabel;
        private TextBox FindTextBox;
        private ComboBox SortByComboBox;
        private Label OrderByLabel;
    }
}