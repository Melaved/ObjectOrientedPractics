
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace ObjectOrientedPractics.View.AdditionalForms
{
    partial class DiscountPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DiscountFornPanel = new Panel();
            CancelButton = new Button();
            OkButton = new Button();
            CategoryComboBox = new ComboBox();
            CategoryLabel = new Label();
            PercentDiscountLabel = new Label();
            DiscountFornPanel.SuspendLayout();
            SuspendLayout();
            // 
            // DiscountFornPanel
            // 
            DiscountFornPanel.Controls.Add(CancelButton);
            DiscountFornPanel.Controls.Add(OkButton);
            DiscountFornPanel.Controls.Add(CategoryComboBox);
            DiscountFornPanel.Controls.Add(CategoryLabel);
            DiscountFornPanel.Controls.Add(PercentDiscountLabel);
            DiscountFornPanel.Dock = DockStyle.Fill;
            DiscountFornPanel.Location = new Point(0, 0);
            DiscountFornPanel.Margin = new Padding(4, 5, 4, 5);
            DiscountFornPanel.Name = "DiscountFornPanel";
            DiscountFornPanel.Size = new Size(546, 233);
            DiscountFornPanel.TabIndex = 1;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CancelButton.BackColor = SystemColors.AppWorkspace;
            CancelButton.Location = new Point(369, 168);
            CancelButton.Margin = new Padding(4, 5, 4, 5);
            CancelButton.MaximumSize = new Size(133, 38);
            CancelButton.MinimumSize = new Size(77, 38);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(125, 38);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // OkButton
            // 
            OkButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OkButton.BackColor = SystemColors.AppWorkspace;
            OkButton.Location = new Point(237, 168);
            OkButton.Margin = new Padding(4, 5, 4, 5);
            OkButton.MaximumSize = new Size(133, 38);
            OkButton.MinimumSize = new Size(77, 38);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(125, 38);
            OkButton.TabIndex = 3;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = false;
            OkButton.Click += OkDiscountsButton_Click;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(141, 77);
            CategoryComboBox.Margin = new Padding(4, 5, 4, 5);
            CategoryComboBox.MaximumSize = new Size(361, 0);
            CategoryComboBox.MaxLength = 242;
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(353, 33);
            CategoryComboBox.TabIndex = 2;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // CategoryLabel
            // 
            CategoryLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(17, 82);
            CategoryLabel.Margin = new Padding(4, 0, 4, 0);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(88, 25);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Category:";
            // 
            // PercentDiscountLabel
            // 
            PercentDiscountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PercentDiscountLabel.AutoSize = true;
            PercentDiscountLabel.Font = new System.Drawing.Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PercentDiscountLabel.Location = new Point(17, 15);
            PercentDiscountLabel.Margin = new Padding(4, 0, 4, 0);
            PercentDiscountLabel.Name = "PercentDiscountLabel";
            PercentDiscountLabel.Size = new Size(188, 26);
            PercentDiscountLabel.TabIndex = 0;
            PercentDiscountLabel.Text = "Percent Discount:";
            // 
            // DiscountPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 233);
            Controls.Add(DiscountFornPanel);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(568, 289);
            MinimumSize = new Size(465, 243);
            Name = "DiscountPanel";
            Text = "AddDiscountForm";
            DiscountFornPanel.ResumeLayout(false);
            DiscountFornPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel DiscountFornPanel;
        private Button CancelButton;
        private Button OkButton;
        private ComboBox CategoryComboBox;
        private Label CategoryLabel;
        private Label PercentDiscountLabel;
    }
}
