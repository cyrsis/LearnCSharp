namespace Bank_Account
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
            this.label1 = new System.Windows.Forms.Label();
            this.adjustButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount:";
            // 
            // adjustButton
            // 
            this.adjustButton.Location = new System.Drawing.Point(239, 19);
            this.adjustButton.Name = "adjustButton";
            this.adjustButton.Size = new System.Drawing.Size(90, 39);
            this.adjustButton.TabIndex = 1;
            this.adjustButton.Text = "Adjust";
            this.adjustButton.UseVisualStyleBackColor = true;
            this.adjustButton.Click += new System.EventHandler(this.adjustButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(99, 23);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 29);
            this.amountTextBox.TabIndex = 2;
            this.amountTextBox.Text = "-50";
            this.amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // balanceLabel
            // 
            this.balanceLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(116, 102);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(153, 24);
            this.balanceLabel.TabIndex = 3;
            this.balanceLabel.Text = "Balance: $100.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 147);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.adjustButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Bank Account";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adjustButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label balanceLabel;
    }
}

