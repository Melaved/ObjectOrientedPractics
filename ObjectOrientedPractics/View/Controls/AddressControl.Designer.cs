namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            deliveryAddressGroupBox = new GroupBox();
            cityTextBox = new TextBox();
            apartmentTextBox = new TextBox();
            buildingTextBox = new TextBox();
            streetTextBox = new TextBox();
            countryTextBox = new TextBox();
            postIndexTextBox = new TextBox();
            apartmentlabel = new Label();
            citylabel = new Label();
            buildinglabel = new Label();
            streetlabel = new Label();
            countryLabel = new Label();
            postIndexlabel = new Label();
            deliveryAddressGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // deliveryAddressGroupBox
            // 
            deliveryAddressGroupBox.Controls.Add(cityTextBox);
            deliveryAddressGroupBox.Controls.Add(apartmentTextBox);
            deliveryAddressGroupBox.Controls.Add(buildingTextBox);
            deliveryAddressGroupBox.Controls.Add(streetTextBox);
            deliveryAddressGroupBox.Controls.Add(countryTextBox);
            deliveryAddressGroupBox.Controls.Add(postIndexTextBox);
            deliveryAddressGroupBox.Controls.Add(apartmentlabel);
            deliveryAddressGroupBox.Controls.Add(citylabel);
            deliveryAddressGroupBox.Controls.Add(buildinglabel);
            deliveryAddressGroupBox.Controls.Add(streetlabel);
            deliveryAddressGroupBox.Controls.Add(countryLabel);
            deliveryAddressGroupBox.Controls.Add(postIndexlabel);
            deliveryAddressGroupBox.Dock = DockStyle.Fill;
            deliveryAddressGroupBox.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deliveryAddressGroupBox.Location = new Point(0, 0);
            deliveryAddressGroupBox.Name = "deliveryAddressGroupBox";
            deliveryAddressGroupBox.Size = new Size(1059, 350);
            deliveryAddressGroupBox.TabIndex = 0;
            deliveryAddressGroupBox.TabStop = false;
            deliveryAddressGroupBox.Text = "Delivery Address";
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(604, 70);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(373, 28);
            cityTextBox.TabIndex = 11;
            cityTextBox.TextChanged += cityTextBox_TextChanged;
            // 
            // apartmentTextBox
            // 
            apartmentTextBox.Location = new Point(604, 159);
            apartmentTextBox.Name = "apartmentTextBox";
            apartmentTextBox.Size = new Size(194, 28);
            apartmentTextBox.TabIndex = 10;
            apartmentTextBox.TextChanged += apartmentTextBox_TextChanged;
            // 
            // buildingTextBox
            // 
            buildingTextBox.Location = new Point(124, 163);
            buildingTextBox.Name = "buildingTextBox";
            buildingTextBox.Size = new Size(194, 28);
            buildingTextBox.TabIndex = 9;
            buildingTextBox.TextChanged += buildingTextBox_TextChanged;
            // 
            // streetTextBox
            // 
            streetTextBox.Location = new Point(124, 116);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(853, 28);
            streetTextBox.TabIndex = 8;
            streetTextBox.TextChanged += streetTextBox_TextChanged;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(124, 70);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(300, 28);
            countryTextBox.TabIndex = 7;
            countryTextBox.TextChanged += countryTextBox_TextChanged;
            // 
            // postIndexTextBox
            // 
            postIndexTextBox.Location = new Point(124, 28);
            postIndexTextBox.Name = "postIndexTextBox";
            postIndexTextBox.Size = new Size(194, 28);
            postIndexTextBox.TabIndex = 6;
            postIndexTextBox.TextChanged += postIndexTextBox_TextChanged;
            // 
            // apartmentlabel
            // 
            apartmentlabel.AutoSize = true;
            apartmentlabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            apartmentlabel.Location = new Point(502, 159);
            apartmentlabel.Name = "apartmentlabel";
            apartmentlabel.Size = new Size(96, 21);
            apartmentlabel.TabIndex = 5;
            apartmentlabel.Text = "Apartment:";
            // 
            // citylabel
            // 
            citylabel.AutoSize = true;
            citylabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            citylabel.Location = new Point(552, 77);
            citylabel.Name = "citylabel";
            citylabel.Size = new Size(46, 21);
            citylabel.TabIndex = 4;
            citylabel.Text = "City:";
            // 
            // buildinglabel
            // 
            buildinglabel.AutoSize = true;
            buildinglabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buildinglabel.Location = new Point(11, 166);
            buildinglabel.Name = "buildinglabel";
            buildinglabel.Size = new Size(79, 21);
            buildinglabel.TabIndex = 3;
            buildinglabel.Text = "Building:";
            // 
            // streetlabel
            // 
            streetlabel.AutoSize = true;
            streetlabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            streetlabel.Location = new Point(11, 123);
            streetlabel.Name = "streetlabel";
            streetlabel.Size = new Size(63, 21);
            streetlabel.TabIndex = 2;
            streetlabel.Text = "Street:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countryLabel.Location = new Point(11, 77);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(78, 21);
            countryLabel.TabIndex = 1;
            countryLabel.Text = "Country:";
            // 
            // postIndexlabel
            // 
            postIndexlabel.AutoSize = true;
            postIndexlabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            postIndexlabel.Location = new Point(11, 31);
            postIndexlabel.Name = "postIndexlabel";
            postIndexlabel.Size = new Size(98, 21);
            postIndexlabel.TabIndex = 0;
            postIndexlabel.Text = "Post Index:";
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(deliveryAddressGroupBox);
            Name = "AddressControl";
            Size = new Size(1059, 350);
            Load += AddressControl_Load;
            deliveryAddressGroupBox.ResumeLayout(false);
            deliveryAddressGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox deliveryAddressGroupBox;
        private Label apartmentlabel;
        private Label citylabel;
        private Label buildinglabel;
        private Label streetlabel;
        private Label countryLabel;
        private Label postIndexlabel;
        public TextBox cityTextBox;
        public TextBox apartmentTextBox;
        public TextBox buildingTextBox;
        public TextBox streetTextBox;
        public TextBox countryTextBox;
        public TextBox postIndexTextBox;
    }
}
