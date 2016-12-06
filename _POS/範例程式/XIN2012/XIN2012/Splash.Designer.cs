namespace XIN2012
{
    partial class fmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmSplash));
            this.ApplicationTitle = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.Company = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplicationTitle
            // 
            this.ApplicationTitle.AutoSize = true;
            this.ApplicationTitle.BackColor = System.Drawing.Color.White;
            this.ApplicationTitle.Font = new System.Drawing.Font("微軟正黑體", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ApplicationTitle.ForeColor = System.Drawing.Color.Blue;
            this.ApplicationTitle.Location = new System.Drawing.Point(12, 32);
            this.ApplicationTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ApplicationTitle.Name = "ApplicationTitle";
            this.ApplicationTitle.Size = new System.Drawing.Size(356, 55);
            this.ApplicationTitle.TabIndex = 1;
            this.ApplicationTitle.Text = "ApplicationTitle";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.BackColor = System.Drawing.Color.White;
            this.Version.Location = new System.Drawing.Point(212, 284);
            this.Version.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(66, 20);
            this.Version.TabIndex = 2;
            this.Version.Text = "Version";
            // 
            // Company
            // 
            this.Company.AutoSize = true;
            this.Company.BackColor = System.Drawing.Color.White;
            this.Company.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Company.Location = new System.Drawing.Point(212, 252);
            this.Company.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(97, 24);
            this.Company.TabIndex = 3;
            this.Company.Text = "Company";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // fmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 327);
            this.ControlBox = false;
            this.Controls.Add(this.Company);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.ApplicationTitle);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmSplash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ApplicationTitle;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label Company;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}