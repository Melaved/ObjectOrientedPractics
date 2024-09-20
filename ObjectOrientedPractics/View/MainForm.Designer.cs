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
            pages.SuspendLayout();
            Items.SuspendLayout();
            Customers.SuspendLayout();
            SuspendLayout();
            // 
            // pages
            // 
            pages.Controls.Add(Items);
            pages.Controls.Add(Customers);
            pages.Dock = DockStyle.Fill;
            pages.Location = new Point(0, 0);
            pages.Name = "pages";
            pages.SelectedIndex = 0;
            pages.Size = new Size(990, 630);
            pages.TabIndex = 0;
            // 
            // Items
            // 
            Items.Controls.Add(itemsTab1);
            Items.Location = new Point(4, 34);
            Items.Name = "Items";
            Items.Padding = new Padding(3);
            Items.Size = new Size(982, 592);
            Items.TabIndex = 0;
            Items.Text = "Items";
            Items.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(976, 586);
            itemsTab1.TabIndex = 0;
            // 
            // Customers
            // 
            Customers.Controls.Add(customerTab1);
            Customers.Location = new Point(4, 34);
            Customers.Name = "Customers";
            Customers.Size = new Size(982, 592);
            Customers.TabIndex = 1;
            Customers.Text = "Customers";
            Customers.UseVisualStyleBackColor = true;
            // 
            // customerTab1
            // 
            customerTab1.Dock = DockStyle.Fill;
            customerTab1.Location = new Point(0, 0);
            customerTab1.Name = "customerTab1";
            customerTab1.Size = new Size(982, 592);
            customerTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 630);
            Controls.Add(pages);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "ObjestOrientedPractics";
            Load += Form1_Load;
            pages.ResumeLayout(false);
            Items.ResumeLayout(false);
            Customers.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl pages;
        private TabPage Items;
        private View.ItemsTab.ItemsTab itemsTab1;
        private TabPage Customers;
        private View.Tabs.CustomerTab customerTab1;
    }
}
