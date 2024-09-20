namespace ObjectOrientedPractics.View.ItemsTab
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
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            Add = new Button();
            Remove = new Button();
            ItemsListBox = new ListBox();
            groupBox2 = new GroupBox();
            descriptionField = new RichTextBox();
            description = new Label();
            nameField = new RichTextBox();
            name = new Label();
            costField = new MaskedTextBox();
            cost = new Label();
            ID = new Label();
            IDfield = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(1301, 800);
            splitContainer1.SplitterDistance = 545;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Controls.Add(ItemsListBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(545, 800);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Items";
           
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(Add, 0, 0);
            tableLayoutPanel1.Controls.Add(Remove, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(3, 734);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(1);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(539, 63);
            tableLayoutPanel1.TabIndex = 1;
            
            // 
            // Add
            // 
            Add.BackColor = SystemColors.ActiveBorder;
            Add.Dock = DockStyle.Fill;
            Add.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Add.Location = new Point(4, 4);
            Add.Name = "Add";
            Add.Size = new Size(173, 55);
            Add.TabIndex = 0;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Remove
            // 
            Remove.BackColor = SystemColors.ActiveBorder;
            Remove.Dock = DockStyle.Fill;
            Remove.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Remove.Location = new Point(183, 4);
            Remove.Name = "Remove";
            Remove.Size = new Size(173, 55);
            Remove.TabIndex = 1;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = false;
            Remove.Click += Remove_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 18;
            ItemsListBox.Location = new Point(4, 29);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(535, 706);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLightLight;
            groupBox2.Controls.Add(descriptionField);
            groupBox2.Controls.Add(description);
            groupBox2.Controls.Add(nameField);
            groupBox2.Controls.Add(name);
            groupBox2.Controls.Add(costField);
            groupBox2.Controls.Add(cost);
            groupBox2.Controls.Add(ID);
            groupBox2.Controls.Add(IDfield);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(752, 800);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selected Item";
            // 
            // descriptionField
            // 
            descriptionField.Location = new Point(6, 383);
            descriptionField.Name = "descriptionField";
            descriptionField.Size = new Size(634, 243);
            descriptionField.TabIndex = 7;
            descriptionField.Text = "";
            
            // 
            // description
            // 
            description.AutoSize = true;
            description.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            description.Location = new Point(6, 362);
            description.Name = "description";
            description.Size = new Size(92, 18);
            description.TabIndex = 6;
            description.Text = "Description:";
           
            // 
            // nameField
            // 
            nameField.Location = new Point(6, 177);
            nameField.Name = "nameField";
            nameField.Size = new Size(634, 156);
            nameField.TabIndex = 5;
            nameField.Text = "";
           
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            name.Location = new Point(6, 156);
            name.Name = "name";
            name.Size = new Size(54, 18);
            name.TabIndex = 4;
            name.Text = "Name:";
            // 
            // costField
            // 
            
            costField.Location = new Point(64, 84);
            costField.Name = "costField";
            costField.Size = new Size(198, 32);
            costField.TabIndex = 3;
            // 
            // cost
            // 
            cost.AutoSize = true;
            cost.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cost.Location = new Point(6, 90);
            cost.Name = "cost";
            cost.Size = new Size(52, 21);
            cost.TabIndex = 2;
            cost.Text = "Cost:";
            
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ID.Location = new Point(6, 47);
            ID.Name = "ID";
            ID.Size = new Size(32, 21);
            ID.TabIndex = 1;
            ID.Text = "ID:";
            // 
            // IDfield
            // 
            IDfield.Location = new Point(64, 41);
            IDfield.Name = "IDfield";
            IDfield.ReadOnly = true;
            IDfield.Size = new Size(198, 32);
            IDfield.TabIndex = 0;
          
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "ItemsTab";
            Size = new Size(1301, 800);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private ListBox ItemsListBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Add;
        private Button Remove;
        private GroupBox groupBox2;
        private RichTextBox descriptionField;
        private Label description;
        private RichTextBox nameField;
        private Label name;
        private MaskedTextBox costField;
        private Label cost;
        private Label ID;
        private MaskedTextBox IDfield;
    }
}
