namespace FormOverloading
{
    partial class frmReportPrint
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
            this.btnReportPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReportPath
            // 
            this.btnReportPath.Location = new System.Drawing.Point(87, 59);
            this.btnReportPath.Name = "btnReportPath";
            this.btnReportPath.Size = new System.Drawing.Size(166, 49);
            this.btnReportPath.TabIndex = 0;
            this.btnReportPath.Text = "報表路徑";
            this.btnReportPath.UseVisualStyleBackColor = true;
            this.btnReportPath.Click += new System.EventHandler(this.btnReportPath_Click);
            // 
            // frmReportPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 205);
            this.Controls.Add(this.btnReportPath);
            this.Name = "frmReportPrint";
            this.Text = "frmReportPrint";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReportPath;
    }
}