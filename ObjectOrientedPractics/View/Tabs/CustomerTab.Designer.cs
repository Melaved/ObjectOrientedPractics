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
            addressControl1 = new Controls.AddressControl(CustomerslistBox);
            fullNameTextBox = new TextBox();
            idTextBox = new TextBox();
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
            splitContainer1.Size = new Size(1373, 721);
            splitContainer1.SplitterDistance = 628;
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
            groupBox1.Size = new Size(628, 721);
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
            tableLayoutPanel1.Size = new Size(622, 63);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.ActiveBorder;
            AddButton.Dock = DockStyle.Fill;
            AddButton.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddButton.Location = new Point(4, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(200, 55);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = SystemColors.ActiveBorder;
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RemoveButton.Location = new Point(210, 4);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(200, 55);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = false;
            // 
            // CustomerslistBox
            // 
            CustomerslistBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerslistBox.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CustomerslistBox.FormattingEnabled = true;
            CustomerslistBox.ItemHeight = 19;
            CustomerslistBox.Location = new Point(4, 29);
            CustomerslistBox.Name = "CustomerslistBox";
            CustomerslistBox.Size = new Size(618, 593);
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
            splitContainer2.Size = new Size(741, 721);
            splitContainer2.SplitterDistance = 239;
            splitContainer2.TabIndex = 0;
            // 
            // SelectedCustomer
            // 
            SelectedCustomer.BackColor = SystemColors.ControlLightLight;
            SelectedCustomer.Controls.Add(addressControl1);
            SelectedCustomer.Controls.Add(fullNameTextBox);
            SelectedCustomer.Controls.Add(idTextBox);
            SelectedCustomer.Controls.Add(FullNameAdress);
            SelectedCustomer.Controls.Add(IdLabel);
            SelectedCustomer.Dock = DockStyle.Fill;
            SelectedCustomer.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            SelectedCustomer.Location = new Point(0, 0);
            SelectedCustomer.Name = "SelectedCustomer";
            SelectedCustomer.Size = new Size(741, 239);
            SelectedCustomer.TabIndex = 0;
            SelectedCustomer.TabStop = false;
            SelectedCustomer.Text = "Selected Customer";
            // 
            // addressControl1
            // 
            addressControl1.Location = new Point(6, 130);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(1083, 252);
            addressControl1.TabIndex = 4;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fullNameTextBox.Location = new Point(108, 81);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(400, 33);
            fullNameTextBox.TabIndex = 3;
            // 
            // idTextBox
            // 
            idTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            idTextBox.Location = new Point(108, 34);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(1, 33);
            idTextBox.TabIndex = 2;
            // 
            // FullNameAdress
            // 
            FullNameAdress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            IdLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            Size = new Size(1373, 721);
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

        private void AddButton_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox CustomerslistBox;
        private SplitContainer splitContainer2;
        private GroupBox SelectedCustomer;
        private TextBox fullNameTextBox;
        private TextBox idTextBox;
        private Label FullNameAdress;
        private Label IdLabel;
        private Button AddButton;
        private Button RemoveButton;
        private Controls.AddressControl addressControl1;
    }
}
