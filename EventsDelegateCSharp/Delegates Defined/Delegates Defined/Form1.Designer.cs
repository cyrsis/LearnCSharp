namespace Delegates_Defined
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
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.accountNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.balanceRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Location = new System.Drawing.Point(12, 12);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(89, 30);
            this.nameRadioButton.TabIndex = 0;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            this.nameRadioButton.Click += new System.EventHandler(this.sortByRadioButton_Click);
            // 
            // accountNumberRadioButton
            // 
            this.accountNumberRadioButton.AutoSize = true;
            this.accountNumberRadioButton.Location = new System.Drawing.Point(152, 12);
            this.accountNumberRadioButton.Name = "accountNumberRadioButton";
            this.accountNumberRadioButton.Size = new System.Drawing.Size(193, 30);
            this.accountNumberRadioButton.TabIndex = 1;
            this.accountNumberRadioButton.TabStop = true;
            this.accountNumberRadioButton.Text = "Account Number";
            this.accountNumberRadioButton.UseVisualStyleBackColor = true;
            this.accountNumberRadioButton.Click += new System.EventHandler(this.sortByRadioButton_Click);
            // 
            // balanceRadioButton
            // 
            this.balanceRadioButton.AutoSize = true;
            this.balanceRadioButton.Location = new System.Drawing.Point(388, 12);
            this.balanceRadioButton.Name = "balanceRadioButton";
            this.balanceRadioButton.Size = new System.Drawing.Size(109, 30);
            this.balanceRadioButton.TabIndex = 2;
            this.balanceRadioButton.TabStop = true;
            this.balanceRadioButton.Text = "Balance";
            this.balanceRadioButton.UseVisualStyleBackColor = true;
            this.balanceRadioButton.Click += new System.EventHandler(this.sortByRadioButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 162);
            this.Controls.Add(this.balanceRadioButton);
            this.Controls.Add(this.accountNumberRadioButton);
            this.Controls.Add(this.nameRadioButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.Name = "Form1";
            this.Text = "Delegates Defined";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.RadioButton accountNumberRadioButton;
        private System.Windows.Forms.RadioButton balanceRadioButton;
    }
}

