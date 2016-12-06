namespace XIN2012
{
    partial class fmBasePreviewReport
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
            this.reportViewerBase = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerBase
            // 
            this.reportViewerBase.Location = new System.Drawing.Point(64, 80);
            this.reportViewerBase.Name = "reportViewerBase";
            this.reportViewerBase.Size = new System.Drawing.Size(396, 246);
            this.reportViewerBase.TabIndex = 0;
            // 
            // fmBasePreviewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 374);
            this.Controls.Add(this.reportViewerBase);
            this.Name = "fmBasePreviewReport";
            this.Text = "BasePreviewReport";
            this.Load += new System.EventHandler(this.fmBasePreviewReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        protected Microsoft.Reporting.WinForms.ReportViewer reportViewerBase;

    }
}