namespace Predefined_Delegate_Types
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
            this.giveRaisesButton = new System.Windows.Forms.Button();
            this.employeesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // giveRaisesButton
            // 
            this.giveRaisesButton.Location = new System.Drawing.Point(12, 175);
            this.giveRaisesButton.Name = "giveRaisesButton";
            this.giveRaisesButton.Size = new System.Drawing.Size(136, 43);
            this.giveRaisesButton.TabIndex = 5;
            this.giveRaisesButton.Text = "Give Raises";
            this.giveRaisesButton.UseVisualStyleBackColor = true;
            this.giveRaisesButton.Click += new System.EventHandler(this.giveRaisesButton_Click);
            // 
            // employeesListBox
            // 
            this.employeesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeesListBox.FormattingEnabled = true;
            this.employeesListBox.IntegralHeight = false;
            this.employeesListBox.ItemHeight = 24;
            this.employeesListBox.Location = new System.Drawing.Point(12, 12);
            this.employeesListBox.Name = "employeesListBox";
            this.employeesListBox.Size = new System.Drawing.Size(410, 142);
            this.employeesListBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 230);
            this.Controls.Add(this.giveRaisesButton);
            this.Controls.Add(this.employeesListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Predefined Delegate Types";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button giveRaisesButton;
        private System.Windows.Forms.ListBox employeesListBox;
    }
}

