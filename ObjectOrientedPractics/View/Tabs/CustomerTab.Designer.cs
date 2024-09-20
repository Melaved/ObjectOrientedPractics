namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomerTab
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
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            AddButton = new Button();
            RemoveButton = new Button();
            CustomerslistBox = new ListBox();
            splitContainer2 = new SplitContainer();
            SelectedCustomer = new GroupBox();
            richTextBox1 = new RichTextBox();
            AdressLabel = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            FullNameAdress = new Label();
            IdLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.SuspendLayout();
            SelectedCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1301, 800);
            splitContainer1.SplitterDistance = 545;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(CustomerslistBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 721);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customers";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(AddButton, 0, 0);
            tableLayoutPanel1.Controls.Add(RemoveButton, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(3, 655);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(1);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(464, 63);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.ActiveBorder;
            AddButton.Dock = DockStyle.Fill;
            AddButton.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddButton.Location = new Point(4, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(147, 55);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = SystemColors.ActiveBorder;
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RemoveButton.Location = new Point(157, 4);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(147, 55);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = false;
            // 
            // CustomerslistBox
            // 
            CustomerslistBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerslistBox.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CustomerslistBox.FormattingEnabled = true;
            CustomerslistBox.ItemHeight = 18;
            CustomerslistBox.Location = new Point(4, 29);
            CustomerslistBox.Name = "CustomerslistBox";
            CustomerslistBox.Size = new Size(535, 706);
            CustomerslistBox.TabIndex = 1;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(SelectedCustomer);
            splitContainer2.Size = new Size(650, 721);
            splitContainer2.SplitterDistance = 344;
            splitContainer2.TabIndex = 0;
            // 
            // SelectedCustomer
            // 
            SelectedCustomer.BackColor = SystemColors.ControlLightLight;
            SelectedCustomer.Controls.Add(richTextBox1);
            SelectedCustomer.Controls.Add(AdressLabel);
            SelectedCustomer.Controls.Add(textBox2);
            SelectedCustomer.Controls.Add(textBox1);
            SelectedCustomer.Controls.Add(FullNameAdress);
            SelectedCustomer.Controls.Add(IdLabel);
            SelectedCustomer.Dock = DockStyle.Fill;
            SelectedCustomer.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            SelectedCustomer.Location = new Point(0, 0);
            SelectedCustomer.Name = "SelectedCustomer";
            SelectedCustomer.Size = new Size(650, 344);
            SelectedCustomer.TabIndex = 0;
            SelectedCustomer.TabStop = false;
            SelectedCustomer.Text = "Selected Customer";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(108, 146);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(464, 169);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // AdressLabel
            // 
            AdressLabel.AutoSize = true;
            AdressLabel.Font = new Font("Arial", 9F);
            AdressLabel.Location = new Point(6, 146);
            AdressLabel.Name = "AdressLabel";
            AdressLabel.Size = new Size(70, 21);
            AdressLabel.TabIndex = 5;
            AdressLabel.Text = "Adress:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(462, 33);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 33);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // FullNameAdress
            // 
            FullNameAdress.AutoSize = true;
            FullNameAdress.Font = new Font("Arial", 9F);
            FullNameAdress.Location = new Point(6, 93);
            FullNameAdress.Name = "FullNameAdress";
            FullNameAdress.Size = new Size(96, 21);
            FullNameAdress.TabIndex = 1;
            FullNameAdress.Text = "Full Name:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new Font("Arial", 9F);
            IdLabel.Location = new Point(6, 46);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(32, 21);
            IdLabel.TabIndex = 0;
            IdLabel.Text = "ID:";
            // 
            // CustomerTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "CustomerTab";
            Size = new Size(1124, 721);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            SelectedCustomer.ResumeLayout(false);
            SelectedCustomer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox CustomerslistBox;
        private SplitContainer splitContainer2;
        private GroupBox SelectedCustomer;
        private Label AdressLabel;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label FullNameAdress;
        private Label IdLabel;
        private RichTextBox richTextBox1;
        private Button AddButton;
        private Button RemoveButton;
    }
}
