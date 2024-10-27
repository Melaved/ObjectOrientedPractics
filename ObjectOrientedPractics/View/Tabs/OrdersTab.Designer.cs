
namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            Address address3 = new Address();
            SelectedOrderGroupBox = new GroupBox();
            StatusComboBox = new ComboBox();
            CreatedTextBox = new TextBox();
            IdTextBox = new TextBox();
            StatusLabel = new Label();
            CreatedLabel = new Label();
            IdLabel = new Label();
            OrderItemsLabel = new Label();
            OrderItemsListBox = new ListBox();
            AmountLabel = new Label();
            TotalCostLabel = new Label();
            OrdersDataGridView = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            CreatedColumn = new DataGridViewTextBoxColumn();
            OrderStatusColumn = new DataGridViewTextBoxColumn();
            CustomerFullNameColumn = new DataGridViewTextBoxColumn();
            AddressControl = new Controls.AddressControl();
            DataGridGroupBox = new GroupBox();
            OrderItemsGroupBox = new GroupBox();
            SelectedOrderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            DataGridGroupBox.SuspendLayout();
            OrderItemsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SelectedOrderGroupBox
            // 
            SelectedOrderGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelectedOrderGroupBox.Controls.Add(StatusComboBox);
            SelectedOrderGroupBox.Controls.Add(CreatedTextBox);
            SelectedOrderGroupBox.Controls.Add(IdTextBox);
            SelectedOrderGroupBox.Controls.Add(StatusLabel);
            SelectedOrderGroupBox.Controls.Add(CreatedLabel);
            SelectedOrderGroupBox.Controls.Add(IdLabel);
            SelectedOrderGroupBox.Location = new Point(466, 5);
            SelectedOrderGroupBox.Margin = new Padding(4, 5, 4, 5);
            SelectedOrderGroupBox.Name = "SelectedOrderGroupBox";
            SelectedOrderGroupBox.Padding = new Padding(4, 5, 4, 5);
            SelectedOrderGroupBox.Size = new Size(663, 213);
            SelectedOrderGroupBox.TabIndex = 0;
            SelectedOrderGroupBox.TabStop = false;
            SelectedOrderGroupBox.Text = "Selected Order";
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(93, 152);
            StatusComboBox.Margin = new Padding(4, 5, 4, 5);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(171, 33);
            StatusComboBox.TabIndex = 5;
            // 
            // CreatedTextBox
            // 
            CreatedTextBox.Location = new Point(93, 93);
            CreatedTextBox.Margin = new Padding(4, 5, 4, 5);
            CreatedTextBox.Name = "CreatedTextBox";
            CreatedTextBox.Size = new Size(171, 31);
            CreatedTextBox.TabIndex = 4;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(93, 37);
            IdTextBox.Margin = new Padding(4, 5, 4, 5);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(171, 31);
            IdTextBox.TabIndex = 3;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(9, 157);
            StatusLabel.Margin = new Padding(4, 0, 4, 0);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(64, 25);
            StatusLabel.TabIndex = 2;
            StatusLabel.Text = "Status:";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Location = new Point(9, 98);
            CreatedLabel.Margin = new Padding(4, 0, 4, 0);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(77, 25);
            CreatedLabel.TabIndex = 1;
            CreatedLabel.Text = "Created:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(9, 42);
            IdLabel.Margin = new Padding(4, 0, 4, 0);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(34, 25);
            IdLabel.TabIndex = 0;
            IdLabel.Text = "ID:";
            // 
            // OrderItemsLabel
            // 
            OrderItemsLabel.AutoSize = true;
            OrderItemsLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrderItemsLabel.Location = new Point(466, 565);
            OrderItemsLabel.Margin = new Padding(4, 0, 4, 0);
            OrderItemsLabel.Name = "OrderItemsLabel";
            OrderItemsLabel.Size = new Size(119, 25);
            OrderItemsLabel.TabIndex = 2;
            OrderItemsLabel.Text = "Order Items";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 25;
            OrderItemsListBox.Location = new Point(4, 30);
            OrderItemsListBox.Margin = new Padding(4, 5, 4, 5);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(658, 204);
            OrderItemsListBox.TabIndex = 3;
            OrderItemsListBox.SelectedIndexChanged += OrderItemsListBox_SelectedIndexChanged;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Dock = DockStyle.Bottom;
            AmountLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(4, 368);
            AmountLabel.Margin = new Padding(4, 0, 4, 0);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(90, 25);
            AmountLabel.TabIndex = 4;
            AmountLabel.Text = "Amount:";
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Dock = DockStyle.Bottom;
            TotalCostLabel.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalCostLabel.Location = new Point(4, 328);
            TotalCostLabel.Margin = new Padding(4, 0, 4, 0);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(68, 40);
            TotalCostLabel.TabIndex = 5;
            TotalCostLabel.Text = "555";
            TotalCostLabel.Click += TotalCostLabel_Click;
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.AllowUserToResizeColumns = false;
            OrdersDataGridView.AllowUserToResizeRows = false;
            OrdersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdColumn, CreatedColumn, OrderStatusColumn, CustomerFullNameColumn });
            OrdersDataGridView.Location = new Point(16, 20);
            OrdersDataGridView.Margin = new Padding(4, 5, 4, 5);
            OrdersDataGridView.MinimumSize = new Size(437, 760);
            OrdersDataGridView.MultiSelect = false;
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.RightToLeft = RightToLeft.No;
            OrdersDataGridView.RowHeadersWidth = 30;
            OrdersDataGridView.Size = new Size(437, 935);
            OrdersDataGridView.TabIndex = 6;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "Id";
            IdColumn.MinimumWidth = 8;
            IdColumn.Name = "IdColumn";
            IdColumn.Width = 150;
            // 
            // CreatedColumn
            // 
            CreatedColumn.HeaderText = "Created";
            CreatedColumn.MinimumWidth = 8;
            CreatedColumn.Name = "CreatedColumn";
            CreatedColumn.Width = 150;
            // 
            // OrderStatusColumn
            // 
            OrderStatusColumn.HeaderText = "Order Status";
            OrderStatusColumn.MinimumWidth = 8;
            OrderStatusColumn.Name = "OrderStatusColumn";
            OrderStatusColumn.Width = 150;
            // 
            // CustomerFullNameColumn
            // 
            CustomerFullNameColumn.HeaderText = "Customer FullName";
            CustomerFullNameColumn.MinimumWidth = 8;
            CustomerFullNameColumn.Name = "CustomerFullNameColumn";
            CustomerFullNameColumn.Width = 150;
            // 
            // AddressControl
            // 
            address3.Apartment = "";
            address3.Building = "";
            address3.City = "";
            address3.Country = "";
            address3.Index = 100000;
            address3.Street = "";
            AddressControl.Address = address3;
            AddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl.Location = new Point(466, 242);
            AddressControl.Margin = new Padding(4, 3, 4, 3);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(663, 302);
            AddressControl.TabIndex = 7;
            // 
            // DataGridGroupBox
            // 
            DataGridGroupBox.Controls.Add(OrdersDataGridView);
            DataGridGroupBox.Dock = DockStyle.Left;
            DataGridGroupBox.Location = new Point(0, 0);
            DataGridGroupBox.Margin = new Padding(4, 5, 4, 5);
            DataGridGroupBox.Name = "DataGridGroupBox";
            DataGridGroupBox.Padding = new Padding(4, 5, 4, 5);
            DataGridGroupBox.Size = new Size(457, 993);
            DataGridGroupBox.TabIndex = 8;
            DataGridGroupBox.TabStop = false;
            // 
            // OrderItemsGroupBox
            // 
            OrderItemsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsGroupBox.Controls.Add(OrderItemsListBox);
            OrderItemsGroupBox.Controls.Add(TotalCostLabel);
            OrderItemsGroupBox.Controls.Add(AmountLabel);
            OrderItemsGroupBox.Location = new Point(461, 565);
            OrderItemsGroupBox.Margin = new Padding(4, 5, 4, 5);
            OrderItemsGroupBox.Name = "OrderItemsGroupBox";
            OrderItemsGroupBox.Padding = new Padding(4, 5, 4, 5);
            OrderItemsGroupBox.Size = new Size(669, 398);
            OrderItemsGroupBox.TabIndex = 9;
            OrderItemsGroupBox.TabStop = false;
            OrderItemsGroupBox.Text = "groupBox1";
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddressControl);
            Controls.Add(OrderItemsLabel);
            Controls.Add(SelectedOrderGroupBox);
            Controls.Add(DataGridGroupBox);
            Controls.Add(OrderItemsGroupBox);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1151, 993);
            Name = "OrdersTab";
            Size = new Size(1151, 993);
            SelectedOrderGroupBox.ResumeLayout(false);
            SelectedOrderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            DataGridGroupBox.ResumeLayout(false);
            OrderItemsGroupBox.ResumeLayout(false);
            OrderItemsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox SelectedOrderGroupBox;
        private Label IdLabel;
        private Label StatusLabel;
        private Label CreatedLabel;
        private ComboBox StatusComboBox;
        private TextBox CreatedTextBox;
        private TextBox IdTextBox;
        private Label OrderItemsLabel;
        private ListBox OrderItemsListBox;
        private Label AmountLabel;
        private Label TotalCostLabel;
        private DataGridView OrdersDataGridView;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn CreatedColumn;
        private DataGridViewTextBoxColumn OrderStatusColumn;
        private DataGridViewTextBoxColumn CustomerFullNameColumn;
        private Label label1;
        private GroupBox OrderItemsGroupBox;
        private Controls.AddressControl AddressControl;
        private GroupBox DataGridGroupBox;
    }
}
