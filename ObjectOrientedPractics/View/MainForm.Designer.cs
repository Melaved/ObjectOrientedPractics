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
            pages = new TabControl();
            Items = new TabPage();
            itemsTab1 = new View.ItemsTab.ItemsTab();
            itemsTab2 = new View.ItemsTab.ItemsTab();
            itemsTab3 = new View.ItemsTab.ItemsTab();
            pages.SuspendLayout();
            Items.SuspendLayout();
            SuspendLayout();
            // 
            // pages
            // 
            pages.Controls.Add(Items);
            pages.Dock = DockStyle.Fill;
            pages.Location = new Point(0, 0);
            pages.Name = "pages";
            pages.SelectedIndex = 0;
            pages.Size = new Size(990, 630);
            pages.TabIndex = 0;
            // 
            // Items
            // 
            Items.Controls.Add(itemsTab3);
            Items.Controls.Add(itemsTab2);
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
            // itemsTab2
            // 
            itemsTab2.Location = new Point(163, 177);
            itemsTab2.Name = "itemsTab2";
            itemsTab2.Size = new Size(225, 225);
            itemsTab2.TabIndex = 1;
            // 
            // itemsTab3
            // 
            itemsTab3.Location = new Point(196, 168);
            itemsTab3.Name = "itemsTab3";
            itemsTab3.Size = new Size(445, 318);
            itemsTab3.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 630);
            Controls.Add(pages);
            Name = "MainForm";
            Text = "ObjestOrientedPractics";
            Load += Form1_Load;
            pages.ResumeLayout(false);
            Items.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl pages;
        private TabPage Items;
        private View.ItemsTab.ItemsTab itemsTab1;
        private View.ItemsTab.ItemsTab itemsTab3;
        private View.ItemsTab.ItemsTab itemsTab2;
    }
}
