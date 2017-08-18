namespace CustomDialogs
{
    partial class ConfirmDialog
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.NoButton = new System.Windows.Forms.Button();
            this.YesButton = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(290, 71);
            this.Panel1.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(158, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Are you sure you want to close?";
            // 
            // NoButton
            // 
            this.NoButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.NoButton.Location = new System.Drawing.Point(205, 80);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 5;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            // 
            // YesButton
            // 
            this.YesButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.YesButton.Location = new System.Drawing.Point(124, 80);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 4;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 107);
            this.ControlBox = false;
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConfirmDialog";
            this.Text = "ConfirmDialog";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button NoButton;
        internal System.Windows.Forms.Button YesButton;
    }
}