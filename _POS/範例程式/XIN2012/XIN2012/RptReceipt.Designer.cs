namespace XIN2012
{
    partial class fmRptReceipt
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.XINDataSet = new XIN2012.XINDataSet();
            this.ReceiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReceiptTableAdapter = new XIN2012.XINDataSetTableAdapters.ReceiptTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.XINDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerBase
            // 
            this.reportViewerBase.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetReceipt";
            reportDataSource2.Value = this.ReceiptBindingSource;
            this.reportViewerBase.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerBase.LocalReport.DisplayName = "BasePreviewReport";
            this.reportViewerBase.LocalReport.ReportEmbeddedResource = "XIN2012.RptReceive.rdlc";
            this.reportViewerBase.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBase.Size = new System.Drawing.Size(648, 381);
            // 
            // XINDataSet
            // 
            this.XINDataSet.DataSetName = "XINDataSet";
            this.XINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReceiptBindingSource
            // 
            this.ReceiptBindingSource.DataMember = "Receipt";
            this.ReceiptBindingSource.DataSource = this.XINDataSet;
            // 
            // ReceiptTableAdapter
            // 
            this.ReceiptTableAdapter.ClearBeforeFill = true;
            // 
            // fmRptReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(648, 381);
            this.Name = "fmRptReceipt";
            this.Text = "進貨（退出）單";
            ((System.ComponentModel.ISupportInitialize)(this.XINDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ReceiptBindingSource;
        private XINDataSet XINDataSet;
        private XINDataSetTableAdapters.ReceiptTableAdapter ReceiptTableAdapter;
    }
}
