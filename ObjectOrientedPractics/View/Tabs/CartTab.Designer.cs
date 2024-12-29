namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartTab
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
            CustomerGroupBox = new GroupBox();
            CustomerGroupBox2 = new GroupBox();
            CreateOrderButton = new Button();
            AmountLabel = new Label();
            TotalCostLabel = new Label();
            ClearCartButton = new Button();
            RemoveItemButtton = new Button();
            CartListBox = new ListBox();
            CartLabel = new Label();
            CustomerLabel = new Label();
            CustomerComboBox = new ComboBox();
            ItemsGroupBox = new GroupBox();
            AddToCartButton = new Button();
            ItemsListBox = new ListBox();
            DiscountsPanel = new Panel();
            TotalCostWithDiscountLabel = new Label();
            TotalLabel = new Label();
            TotalDiscountLabel = new Label();
            DiscoumtAmountLabel = new Label();
            DiscountsLabel = new Label();
            DiscountsCheckedListBox = new CheckedListBox();
            CustomerGroupBox.SuspendLayout();
            CustomerGroupBox2.SuspendLayout();
            ItemsGroupBox.SuspendLayout();
            DiscountsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CustomerGroupBox
            // 
            CustomerGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerGroupBox.BackgroundImageLayout = ImageLayout.None;
            CustomerGroupBox.Controls.Add(CustomerGroupBox2);
            CustomerGroupBox.Controls.Add(CartListBox);
            CustomerGroupBox.Controls.Add(CartLabel);
            CustomerGroupBox.Controls.Add(CustomerLabel);
            CustomerGroupBox.Controls.Add(CustomerComboBox);
            CustomerGroupBox.Location = new Point(286, 5);
            CustomerGroupBox.Margin = new Padding(4, 5, 4, 5);
            CustomerGroupBox.MinimumSize = new Size(436, 417);
            CustomerGroupBox.Name = "CustomerGroupBox";
            CustomerGroupBox.Padding = new Padding(4, 5, 4, 5);
            CustomerGroupBox.Size = new Size(621, 657);
            CustomerGroupBox.TabIndex = 12;
            CustomerGroupBox.TabStop = false;
            // 
            // CustomerGroupBox2
            // 
            CustomerGroupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerGroupBox2.Controls.Add(CreateOrderButton);
            CustomerGroupBox2.Controls.Add(AmountLabel);
            CustomerGroupBox2.Controls.Add(TotalCostLabel);
            CustomerGroupBox2.Controls.Add(ClearCartButton);
            CustomerGroupBox2.Controls.Add(RemoveItemButtton);
            CustomerGroupBox2.Location = new Point(20, 399);
            CustomerGroupBox2.Margin = new Padding(4, 5, 4, 5);
            CustomerGroupBox2.MinimumSize = new Size(429, 175);
            CustomerGroupBox2.Name = "CustomerGroupBox2";
            CustomerGroupBox2.Padding = new Padding(4, 5, 4, 5);
            CustomerGroupBox2.Size = new Size(596, 175);
            CustomerGroupBox2.TabIndex = 13;
            CustomerGroupBox2.TabStop = false;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Location = new Point(9, 118);
            CreateOrderButton.Margin = new Padding(4, 5, 4, 5);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(159, 38);
            CreateOrderButton.TabIndex = 8;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.ForeColor = SystemColors.ControlText;
            AmountLabel.Location = new Point(490, 17);
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
            TotalCostLabel.Location = new Point(490, 62);
            TotalCostLabel.Margin = new Padding(4, 0, 4, 0);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(86, 32);
            TotalCostLabel.TabIndex = 7;
            TotalCostLabel.Text = "44777";
            // 
            // ClearCartButton
            // 
            ClearCartButton.Location = new Point(341, 118);
            ClearCartButton.Margin = new Padding(4, 5, 4, 5);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(141, 38);
            ClearCartButton.TabIndex = 10;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
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
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 25;
            CartListBox.Location = new Point(20, 122);
            CartListBox.Margin = new Padding(4, 5, 4, 5);
            CartListBox.MinimumSize = new Size(383, 279);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(544, 279);
            CartListBox.TabIndex = 11;
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Location = new Point(20, 75);
            CartLabel.Margin = new Padding(4, 0, 4, 0);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(48, 25);
            CartLabel.TabIndex = 4;
            CartLabel.Text = "Cart:";
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Location = new Point(20, 32);
            CustomerLabel.Margin = new Padding(4, 0, 4, 0);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(98, 25);
            CustomerLabel.TabIndex = 2;
            CustomerLabel.Text = "Customer: ";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(131, 27);
            CustomerComboBox.Margin = new Padding(4, 5, 4, 5);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(433, 33);
            CustomerComboBox.TabIndex = 3;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsGroupBox.Controls.Add(AddToCartButton);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Location = new Point(0, 0);
            ItemsGroupBox.Margin = new Padding(4, 5, 4, 5);
            ItemsGroupBox.MinimumSize = new Size(286, 667);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Padding = new Padding(4, 5, 4, 5);
            ItemsGroupBox.Size = new Size(286, 960);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // AddToCartButton
            // 
            AddToCartButton.Dock = DockStyle.Bottom;
            AddToCartButton.Location = new Point(4, 905);
            AddToCartButton.Margin = new Padding(4, 5, 4, 5);
            AddToCartButton.MinimumSize = new Size(114, 50);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(278, 50);
            AddToCartButton.TabIndex = 1;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 25;
            ItemsListBox.Location = new Point(4, 32);
            ItemsListBox.Margin = new Padding(4, 5, 4, 5);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(271, 804);
            ItemsListBox.TabIndex = 11;
            // 
            // DiscountsPanel
            // 
            DiscountsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DiscountsPanel.Controls.Add(TotalCostWithDiscountLabel);
            DiscountsPanel.Controls.Add(TotalLabel);
            DiscountsPanel.Controls.Add(TotalDiscountLabel);
            DiscountsPanel.Controls.Add(DiscoumtAmountLabel);
            DiscountsPanel.Controls.Add(DiscountsLabel);
            DiscountsPanel.Controls.Add(DiscountsCheckedListBox);
            DiscountsPanel.Location = new Point(294, 647);
            DiscountsPanel.Margin = new Padding(4, 5, 4, 5);
            DiscountsPanel.Name = "DiscountsPanel";
            DiscountsPanel.Size = new Size(607, 308);
            DiscountsPanel.TabIndex = 13;
            // 
            // TotalCostWithDiscountLabel
            // 
            TotalCostWithDiscountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TotalCostWithDiscountLabel.AutoSize = true;
            TotalCostWithDiscountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalCostWithDiscountLabel.Location = new Point(484, 232);
            TotalCostWithDiscountLabel.Margin = new Padding(4, 0, 4, 0);
            TotalCostWithDiscountLabel.Name = "TotalCostWithDiscountLabel";
            TotalCostWithDiscountLabel.Size = new Size(112, 32);
            TotalCostWithDiscountLabel.TabIndex = 5;
            TotalCostWithDiscountLabel.Text = "4 500,00";
            // 
            // TotalLabel
            // 
            TotalLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalLabel.Location = new Point(513, 197);
            TotalLabel.Margin = new Padding(4, 0, 4, 0);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(77, 32);
            TotalLabel.TabIndex = 4;
            TotalLabel.Text = "Total:";
            // 
            // TotalDiscountLabel
            // 
            TotalDiscountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TotalDiscountLabel.AutoSize = true;
            TotalDiscountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalDiscountLabel.Location = new Point(534, 83);
            TotalDiscountLabel.Margin = new Padding(4, 0, 4, 0);
            TotalDiscountLabel.Name = "TotalDiscountLabel";
            TotalDiscountLabel.Size = new Size(56, 32);
            TotalDiscountLabel.TabIndex = 3;
            TotalDiscountLabel.Text = "499";
            // 
            // DiscoumtAmountLabel
            // 
            DiscoumtAmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DiscoumtAmountLabel.AutoSize = true;
            DiscoumtAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscoumtAmountLabel.Location = new Point(434, 42);
            DiscoumtAmountLabel.Margin = new Padding(4, 0, 4, 0);
            DiscoumtAmountLabel.Name = "DiscoumtAmountLabel";
            DiscoumtAmountLabel.Size = new Size(166, 25);
            DiscoumtAmountLabel.TabIndex = 2;
            DiscoumtAmountLabel.Text = "Discount Amount:";
            // 
            // DiscountsLabel
            // 
            DiscountsLabel.AutoSize = true;
            DiscountsLabel.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountsLabel.Location = new Point(11, 12);
            DiscountsLabel.Margin = new Padding(4, 0, 4, 0);
            DiscountsLabel.Name = "DiscountsLabel";
            DiscountsLabel.Size = new Size(116, 26);
            DiscountsLabel.TabIndex = 1;
            DiscountsLabel.Text = "Discounts:";
            // 
            // DiscountsCheckedListBox
            // 
            DiscountsCheckedListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DiscountsCheckedListBox.FormattingEnabled = true;
            DiscountsCheckedListBox.Location = new Point(11, 42);
            DiscountsCheckedListBox.Margin = new Padding(4, 5, 4, 5);
            DiscountsCheckedListBox.MaximumSize = new Size(444, 304);
            DiscountsCheckedListBox.Name = "DiscountsCheckedListBox";
            DiscountsCheckedListBox.Size = new Size(370, 200);
            DiscountsCheckedListBox.TabIndex = 0;
            DiscountsCheckedListBox.SelectedIndexChanged += DiscountsCheckedListBox_SelectedIndexChanged;
            // 
            // CartTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DiscountsPanel);
            Controls.Add(ItemsGroupBox);
            Controls.Add(CustomerGroupBox);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(907, 965);
            Name = "CartTab";
            Size = new Size(907, 965);
            CustomerGroupBox.ResumeLayout(false);
            CustomerGroupBox.PerformLayout();
            CustomerGroupBox2.ResumeLayout(false);
            CustomerGroupBox2.PerformLayout();
            ItemsGroupBox.ResumeLayout(false);
            DiscountsPanel.ResumeLayout(false);
            DiscountsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CustomerGroupBox;
        private ListBox CartListBox;
        private Label CartLabel;
        private Label CustomerLabel;
        private ComboBox CustomerComboBox;
        private GroupBox ItemsGroupBox;
        private ListBox ItemsListBox;
        private Button AddToCartButton;
        private GroupBox CustomerGroupBox2;
        private Button CreateOrderButton;
        private Label AmountLabel;
        private Label TotalCostLabel;
        private Button ClearCartButton;
        private Button RemoveItemButtton;
        private Panel DiscountsPanel;
        private CheckedListBox DiscountsCheckedListBox;
        private Label TotalDiscountLabel;
        private Label DiscoumtAmountLabel;
        private Label DiscountsLabel;
        private Label TotalCostWithDiscountLabel;
        private Label TotalLabel;
    }
}