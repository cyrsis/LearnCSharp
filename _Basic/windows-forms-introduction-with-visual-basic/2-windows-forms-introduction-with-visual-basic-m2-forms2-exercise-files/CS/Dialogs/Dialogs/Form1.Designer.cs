namespace Dialogs
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 227);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(0, 13);
            this.Label1.TabIndex = 8;
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button1.Location = new System.Drawing.Point(12, 192);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(132, 23);
            this.Button1.TabIndex = 7;
            this.Button1.Text = "Show Slected Item";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ListBox1
            // 
            this.ListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(12, 13);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(268, 173);
            this.ListBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 252);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.ListBox1);
            this.Name = "Form1";
            this.Text = "Dialogs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.ListBox ListBox1;
    }
}

