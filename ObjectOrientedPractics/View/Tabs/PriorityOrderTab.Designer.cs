namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrderTab
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
            Model.Address address1 = new Model.Address();
            AddressControl = new Controls.AddressControl();
            SelectedOrderGroupBox = new GroupBox();
            PriorityOptionsGroupBox = new GroupBox();
            DeliveryTimeComboBox = new ComboBox();
            DeliveryTimeLabel = new Label();
            StatusComboBox = new ComboBox();
            CreatedTextBox = new TextBox();
            IdTextBox = new TextBox();
            StatusLabel = new Label();
            CreatedLabel = new Label();
            IdLabel = new Label();
            OrderItemsListBox = new ListBox();
            OrderItemsGroupBox = new GroupBox();
            CustomerGroupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            AddItemButton = new Button();
            AmountLabel = new Label();
            TotalCostLabel = new Label();
            ClearOrderButton = new Button();
            RemoveItemButtton = new Button();
            CustomerFullNameColumn = new DataGridViewTextBoxColumn();
            OrderStatusColumn = new DataGridViewTextBoxColumn();
            CreatedColumn = new DataGridViewTextBoxColumn();
            IdColumn = new DataGridViewTextBoxColumn();
            OrdersDataGridView = new DataGridView();
            SelectedOrderGroupBox.SuspendLayout();
            PriorityOptionsGroupBox.SuspendLayout();
            OrderItemsGroupBox.SuspendLayout();
            CustomerGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AddressControl
            // 
            AddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl.Location = new Point(465, 221);
            AddressControl.Margin = new Padding(4, 3, 4, 3);
            AddressControl.MinimumSize = new Size(557, 300);
            AddressControl.Name = "AddressControl";
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            AddressControl.OurAddress = address1;
            AddressControl.Size = new Size(557, 300);
            AddressControl.TabIndex = 9;
            // 
            // SelectedOrderGroupBox
            // 
            SelectedOrderGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelectedOrderGroupBox.Controls.Add(PriorityOptionsGroupBox);
            SelectedOrderGroupBox.Controls.Add(StatusComboBox);
            SelectedOrderGroupBox.Controls.Add(CreatedTextBox);
            SelectedOrderGroupBox.Controls.Add(IdTextBox);
            SelectedOrderGroupBox.Controls.Add(StatusLabel);
            SelectedOrderGroupBox.Controls.Add(CreatedLabel);
            SelectedOrderGroupBox.Controls.Add(IdLabel);
            SelectedOrderGroupBox.Location = new Point(468, 0);
            SelectedOrderGroupBox.Margin = new Padding(4, 5, 4, 5);
            SelectedOrderGroupBox.Name = "SelectedOrderGroupBox";
            SelectedOrderGroupBox.Padding = new Padding(4, 5, 4, 5);
            SelectedOrderGroupBox.Size = new Size(366, 213);
            SelectedOrderGroupBox.TabIndex = 8;
            SelectedOrderGroupBox.TabStop = false;
            SelectedOrderGroupBox.Text = "Selected Order";
            // 
            // PriorityOptionsGroupBox
            // 
            PriorityOptionsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PriorityOptionsGroupBox.Controls.Add(DeliveryTimeComboBox);
            PriorityOptionsGroupBox.Controls.Add(DeliveryTimeLabel);
            PriorityOptionsGroupBox.Location = new Point(274, 0);
            PriorityOptionsGroupBox.Margin = new Padding(4, 5, 4, 5);
            PriorityOptionsGroupBox.Name = "PriorityOptionsGroupBox";
            PriorityOptionsGroupBox.Padding = new Padding(4, 5, 4, 5);
            PriorityOptionsGroupBox.Size = new Size(83, 190);
            PriorityOptionsGroupBox.TabIndex = 6;
            PriorityOptionsGroupBox.TabStop = false;
            PriorityOptionsGroupBox.Text = "Priority Options";
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(133, 43);
            DeliveryTimeComboBox.Margin = new Padding(4, 5, 4, 5);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(120, 33);
            DeliveryTimeComboBox.TabIndex = 1;
            DeliveryTimeComboBox.Text = "9:00 - 11:00";
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // DeliveryTimeLabel
            // 
            DeliveryTimeLabel.AutoSize = true;
            DeliveryTimeLabel.Location = new Point(9, 43);
            DeliveryTimeLabel.Margin = new Padding(4, 0, 4, 0);
            DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            DeliveryTimeLabel.Size = new Size(122, 25);
            DeliveryTimeLabel.TabIndex = 0;
            DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(95, 154);
            StatusComboBox.Margin = new Padding(4, 5, 4, 5);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(171, 33);
            StatusComboBox.TabIndex = 5;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
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
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 25;
            OrderItemsListBox.Location = new Point(8, 34);
            OrderItemsListBox.Margin = new Padding(4, 5, 4, 5);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(535, 154);
            OrderItemsListBox.TabIndex = 10;
            // 
            // OrderItemsGroupBox
            // 
            OrderItemsGroupBox.Controls.Add(CustomerGroupBox2);
            OrderItemsGroupBox.Controls.Add(OrderItemsListBox);
            OrderItemsGroupBox.Location = new Point(473, 529);
            OrderItemsGroupBox.Margin = new Padding(4, 5, 4, 5);
            OrderItemsGroupBox.Name = "OrderItemsGroupBox";
            OrderItemsGroupBox.Padding = new Padding(4, 5, 4, 5);
            OrderItemsGroupBox.Size = new Size(623, 415);
            OrderItemsGroupBox.TabIndex = 11;
            OrderItemsGroupBox.TabStop = false;
            OrderItemsGroupBox.Text = "OrderItems";
            // 
            // CustomerGroupBox2
            // 
            CustomerGroupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerGroupBox2.Controls.Add(label1);
            CustomerGroupBox2.Controls.Add(label2);
            CustomerGroupBox2.Controls.Add(AddItemButton);
            CustomerGroupBox2.Controls.Add(AmountLabel);
            CustomerGroupBox2.Controls.Add(TotalCostLabel);
            CustomerGroupBox2.Controls.Add(ClearOrderButton);
            CustomerGroupBox2.Controls.Add(RemoveItemButtton);
            CustomerGroupBox2.Location = new Point(23, 230);
            CustomerGroupBox2.Margin = new Padding(4, 5, 4, 5);
            CustomerGroupBox2.MinimumSize = new Size(429, 175);
            CustomerGroupBox2.Name = "CustomerGroupBox2";
            CustomerGroupBox2.Padding = new Padding(4, 5, 4, 5);
            CustomerGroupBox2.Size = new Size(537, 175);
            CustomerGroupBox2.TabIndex = 14;
            CustomerGroupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(443, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 11;
            label1.Text = "Amount:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(443, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(28, 32);
            label2.TabIndex = 12;
            label2.Text = "0";
            // 
            // AddItemButton
            // 
            AddItemButton.Location = new Point(9, 118);
            AddItemButton.Margin = new Padding(4, 5, 4, 5);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(159, 38);
            AddItemButton.TabIndex = 8;
            AddItemButton.Text = "Add iItem";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.ForeColor = SystemColors.ControlText;
            AmountLabel.Location = new Point(640, 17);
            AmountLabel.Margin = new Padding(4, 0, 4, 0);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(90, 25);
            AmountLabel.TabIndex = 6;
            AmountLabel.Text = "Amount:";
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalCostLabel.Location = new Point(640, 62);
            TotalCostLabel.Margin = new Padding(4, 0, 4, 0);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(86, 32);
            TotalCostLabel.TabIndex = 7;
            TotalCostLabel.Text = "44777";
            // 
            // ClearOrderButton
            // 
            ClearOrderButton.Location = new Point(506, 117);
            ClearOrderButton.Margin = new Padding(4, 5, 4, 5);
            ClearOrderButton.Name = "ClearOrderButton";
            ClearOrderButton.Size = new Size(141, 48);
            ClearOrderButton.TabIndex = 10;
            ClearOrderButton.Text = "Clear Order";
            ClearOrderButton.UseVisualStyleBackColor = true;
            ClearOrderButton.Click += ClearOrderButton_Click;
            // 
            // RemoveItemButtton
            // 
            RemoveItemButtton.Location = new Point(199, 118);
            RemoveItemButtton.Margin = new Padding(4, 5, 4, 5);
            RemoveItemButtton.Name = "RemoveItemButtton";
            RemoveItemButtton.Size = new Size(134, 38);
            RemoveItemButtton.TabIndex = 9;
            RemoveItemButtton.Text = "Remove Item";
            RemoveItemButtton.UseVisualStyleBackColor = true;
            RemoveItemButtton.Click += RemoveItemButtton_Click;
            // 
            // CustomerFullNameColumn
            // 
            CustomerFullNameColumn.HeaderText = "Customer FullName";
            CustomerFullNameColumn.MinimumWidth = 8;
            CustomerFullNameColumn.Name = "CustomerFullNameColumn";
            CustomerFullNameColumn.Width = 150;
            // 
            // OrderStatusColumn
            // 
            OrderStatusColumn.HeaderText = "Order Status";
            OrderStatusColumn.MinimumWidth = 8;
            OrderStatusColumn.Name = "OrderStatusColumn";
            OrderStatusColumn.Width = 150;
            // 
            // CreatedColumn
            // 
            CreatedColumn.HeaderText = "Created";
            CreatedColumn.MinimumWidth = 8;
            CreatedColumn.Name = "CreatedColumn";
            CreatedColumn.Width = 150;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "Id";
            IdColumn.MinimumWidth = 8;
            IdColumn.Name = "IdColumn";
            IdColumn.Width = 150;
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.AllowUserToResizeColumns = false;
            OrdersDataGridView.AllowUserToResizeRows = false;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdColumn, CreatedColumn, OrderStatusColumn, CustomerFullNameColumn });
            OrdersDataGridView.Dock = DockStyle.Left;
            OrdersDataGridView.Location = new Point(0, 0);
            OrdersDataGridView.Margin = new Padding(4, 5, 4, 5);
            OrdersDataGridView.MinimumSize = new Size(437, 760);
            OrdersDataGridView.MultiSelect = false;
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.RightToLeft = RightToLeft.No;
            OrdersDataGridView.RowHeadersWidth = 30;
            OrdersDataGridView.Size = new Size(437, 1008);
            OrdersDataGridView.TabIndex = 12;
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // PriorityOrderTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OrdersDataGridView);
            Controls.Add(OrderItemsGroupBox);
            Controls.Add(AddressControl);
            Controls.Add(SelectedOrderGroupBox);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PriorityOrderTab";
            Size = new Size(1377, 1008);
            SelectedOrderGroupBox.ResumeLayout(false);
            SelectedOrderGroupBox.PerformLayout();
            PriorityOptionsGroupBox.ResumeLayout(false);
            PriorityOptionsGroupBox.PerformLayout();
            OrderItemsGroupBox.ResumeLayout(false);
            CustomerGroupBox2.ResumeLayout(false);
            CustomerGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Controls.AddressControl AddressControl;
        private GroupBox SelectedOrderGroupBox;
        private ComboBox StatusComboBox;
        private TextBox CreatedTextBox;
        private TextBox IdTextBox;
        private Label StatusLabel;
        private Label CreatedLabel;
        private Label IdLabel;
        private ListBox OrderItemsListBox;
        private GroupBox OrderItemsGroupBox;
        private GroupBox CustomerGroupBox2;
        private Button AddItemButton;
        private Label AmountLabel;
        private Label TotalCostLabel;
        private Button ClearOrderButton;
        private Button RemoveItemButtton;
        private Label label1;
        private Label label2;
        private GroupBox PriorityOptionsGroupBox;
        private ComboBox DeliveryTimeComboBox;
        private Label DeliveryTimeLabel;
        private DataGridViewTextBoxColumn CustomerFullNameColumn;
        private DataGridViewTextBoxColumn OrderStatusColumn;
        private DataGridViewTextBoxColumn CreatedColumn;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridView OrdersDataGridView;
    }
}