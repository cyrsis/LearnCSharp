namespace Designer
{
    partial class MyForm
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
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ShowMessageButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(12, 105);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(39, 13);
            this.MessageLabel.TabIndex = 5;
            this.MessageLabel.Text = "[Label]";
            // 
            // ShowMessageButton
            // 
            this.ShowMessageButton.Location = new System.Drawing.Point(12, 55);
            this.ShowMessageButton.Name = "ShowMessageButton";
            this.ShowMessageButton.Size = new System.Drawing.Size(75, 23);
            this.ShowMessageButton.TabIndex = 4;
            this.ShowMessageButton.Text = "Show Message";
            this.ShowMessageButton.UseVisualStyleBackColor = true;
            this.ShowMessageButton.Click += new System.EventHandler(this.ShowMessageButton_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(12, 12);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(197, 20);
            this.MessageTextBox.TabIndex = 3;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.ShowMessageButton);
            this.Controls.Add(this.MessageTextBox);
            this.Name = "MyForm";
            this.Text = "MyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label MessageLabel;
        internal System.Windows.Forms.Button ShowMessageButton;
        internal System.Windows.Forms.TextBox MessageTextBox;
    }
}

