namespace UserControls
{
    partial class PersonControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(11, 104);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(26, 13);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Age";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(11, 61);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 13);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Last Name";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(11, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(57, 13);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "First Name";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(80, 97);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AgeTextBox.TabIndex = 8;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(80, 58);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTextBox.TabIndex = 7;
            // 
            // FirstTextBox
            // 
            this.FirstTextBox.Location = new System.Drawing.Point(80, 13);
            this.FirstTextBox.Name = "FirstTextBox";
            this.FirstTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstTextBox.TabIndex = 6;
            // 
            // PersonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstTextBox);
            this.Name = "PersonControl";
            this.Size = new System.Drawing.Size(204, 138);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox AgeTextBox;
        internal System.Windows.Forms.TextBox LastNameTextBox;
        internal System.Windows.Forms.TextBox FirstTextBox;
    }
}
