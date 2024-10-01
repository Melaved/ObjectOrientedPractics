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
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            deliveryAddressGroupBox.Controls.Add(textBox6);
            deliveryAddressGroupBox.Controls.Add(textBox5);
            deliveryAddressGroupBox.Controls.Add(textBox4);
            deliveryAddressGroupBox.Controls.Add(textBox3);
            deliveryAddressGroupBox.Controls.Add(textBox2);
            deliveryAddressGroupBox.Controls.Add(textBox1);
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
            // textBox6
            // 
            textBox6.Location = new Point(604, 70);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(378, 28);
            textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(604, 159);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(194, 28);
            textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(124, 163);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(194, 28);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(124, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(858, 28);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 28);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 28);
            textBox1.TabIndex = 6;
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
            deliveryAddressGroupBox.ResumeLayout(false);
            deliveryAddressGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox deliveryAddressGroupBox;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label apartmentlabel;
        private Label citylabel;
        private Label buildinglabel;
        private Label streetlabel;
        private Label countryLabel;
        private Label postIndexlabel;
    }
}
