namespace Using_IComparer
{
    partial class Form1
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
            this.carsListBox = new System.Windows.Forms.ListBox();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.priceRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // carsListBox
            // 
            this.carsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carsListBox.FormattingEnabled = true;
            this.carsListBox.IntegralHeight = false;
            this.carsListBox.ItemHeight = 24;
            this.carsListBox.Location = new System.Drawing.Point(12, 46);
            this.carsListBox.Name = "carsListBox";
            this.carsListBox.Size = new System.Drawing.Size(610, 263);
            this.carsListBox.TabIndex = 0;
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Location = new System.Drawing.Point(12, 12);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(79, 28);
            this.nameRadioButton.TabIndex = 1;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            this.nameRadioButton.Click += new System.EventHandler(this.nameRadioButton_Click);
            // 
            // priceRadioButton
            // 
            this.priceRadioButton.AutoSize = true;
            this.priceRadioButton.Location = new System.Drawing.Point(123, 12);
            this.priceRadioButton.Name = "priceRadioButton";
            this.priceRadioButton.Size = new System.Drawing.Size(71, 28);
            this.priceRadioButton.TabIndex = 2;
            this.priceRadioButton.Text = "Price";
            this.priceRadioButton.UseVisualStyleBackColor = true;
            this.priceRadioButton.Click += new System.EventHandler(this.priceRadioButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 321);
            this.Controls.Add(this.priceRadioButton);
            this.Controls.Add(this.nameRadioButton);
            this.Controls.Add(this.carsListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Using IComparer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox carsListBox;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.RadioButton priceRadioButton;
    }
}

