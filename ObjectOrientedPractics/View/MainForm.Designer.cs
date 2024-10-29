namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pages = new TabControl();
            Items = new TabPage();
            itemsTab1 = new View.ItemsTab.ItemsTab();
            Customers = new TabPage();
            customerTab1 = new View.Tabs.CustomerTab();
            Cart = new TabPage();
            cartsTab1 = new View.Tabs.CartsTab();
            Order = new TabPage();
            ordersTab1 = new View.Tabs.OrdersTab();
            pages.SuspendLayout();
            Items.SuspendLayout();
            Customers.SuspendLayout();
            Cart.SuspendLayout();
            Order.SuspendLayout();
            SuspendLayout();
            // 
            // pages
            // 
            pages.Controls.Add(Items);
            pages.Controls.Add(Customers);
            pages.Controls.Add(Cart);
            pages.Controls.Add(Order);
            pages.Dock = DockStyle.Fill;
            pages.Location = new Point(0, 0);
            pages.Name = "pages";
            pages.SelectedIndex = 0;
            pages.Size = new Size(1126, 1020);
            pages.TabIndex = 0;
            // 
            // Items
            // 
            Items.Controls.Add(itemsTab1);
            Items.Location = new Point(4, 34);
            Items.Name = "Items";
            Items.Padding = new Padding(3);
            Items.Size = new Size(1118, 982);
            Items.TabIndex = 0;
            Items.Text = "Items";
            Items.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(1112, 976);
            itemsTab1.TabIndex = 0;
            // 
            // Customers
            // 
            Customers.Controls.Add(customerTab1);
            Customers.Location = new Point(4, 34);
            Customers.Name = "Customers";
            Customers.Size = new Size(1118, 982);
            Customers.TabIndex = 1;
            Customers.Text = "Customers";
            Customers.UseVisualStyleBackColor = true;
            // 
            // customerTab1
            // 
            customerTab1.Dock = DockStyle.Fill;
            customerTab1.Location = new Point(0, 0);
            customerTab1.Name = "customerTab1";
            customerTab1.Size = new Size(1118, 982);
            customerTab1.TabIndex = 0;
            // 
            // Cart
            // 
            Cart.Controls.Add(cartsTab1);
            Cart.Location = new Point(4, 34);
            Cart.Name = "Cart";
            Cart.Size = new Size(1118, 982);
            Cart.TabIndex = 2;
            Cart.Text = "Cart";
            Cart.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.AutoSize = true;
            cartsTab1.Dock = DockStyle.Fill;
            cartsTab1.Location = new Point(0, 0);
            cartsTab1.Margin = new Padding(4, 5, 4, 5);
            cartsTab1.MinimumSize = new Size(794, 672);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(1118, 982);
            cartsTab1.TabIndex = 0;
            cartsTab1.Load += cartsTab1_Load;
            // 
            // Order
            // 
            Order.Controls.Add(ordersTab1);
            Order.Location = new Point(4, 34);
            Order.Name = "Order";
            Order.Size = new Size(1118, 982);
            Order.TabIndex = 3;
            Order.Text = "Order";
            Order.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            ordersTab1.AutoSize = true;
            ordersTab1.Dock = DockStyle.Fill;
            ordersTab1.Location = new Point(0, 0);
            ordersTab1.Margin = new Padding(4, 5, 4, 5);
            ordersTab1.MinimumSize = new Size(1151, 993);
            ordersTab1.Name = "ordersTab1";
            ordersTab1.Size = new Size(1151, 993);
            ordersTab1.TabIndex = 0;
            ordersTab1.Load += ordersTab1_Load;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 1020);
            Controls.Add(pages);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "ObjestOrientedPractics";
            Load += Form1_Load;
            pages.ResumeLayout(false);
            Items.ResumeLayout(false);
            Customers.ResumeLayout(false);
            Cart.ResumeLayout(false);
            Cart.PerformLayout();
            Order.ResumeLayout(false);
            Order.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl pages;
        private TabPage Items;
        private View.ItemsTab.ItemsTab itemsTab1;
        private TabPage Customers;
        private View.Tabs.CustomerTab customerTab1;
        private TabPage Cart;
        private TabPage Order;
        private View.Tabs.OrdersTab ordersTab1;
        public View.Tabs.CartsTab cartsTab1;
    }
}
