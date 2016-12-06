namespace XIN2012
{
    partial class fmRptReceiptList
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReceiptListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.XINDataSet = new XIN2012.XINDataSet();
            this.ReceiptListTableAdapter = new XIN2012.XINDataSetTableAdapters.ReceiptListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XINDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerBase
            // 
            this.reportViewerBase.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetReceiptList";
            reportDataSource1.Value = this.ReceiptListBindingSource;
            this.reportViewerBase.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerBase.LocalReport.DisplayName = "BasePreviewReport";
            this.reportViewerBase.LocalReport.ReportEmbeddedResource = "XIN2012.RptReceiptList.rdlc";
            this.reportViewerBase.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBase.Size = new System.Drawing.Size(661, 290);
            // 
            // ReceiptListBindingSource
            // 
            this.ReceiptListBindingSource.DataMember = "ReceiptList";
            this.ReceiptListBindingSource.DataSource = this.XINDataSet;
            // 
            // XINDataSet
            // 
            this.XINDataSet.DataSetName = "XINDataSet";
            this.XINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReceiptListTableAdapter
            // 
            this.ReceiptListTableAdapter.ClearBeforeFill = true;
            // 
            // fmRptReceiptList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(661, 290);
            this.Name = "fmRptReceiptList";
            this.Text = "進貨（退出）明細表";
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XINDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ReceiptListBindingSource;
        private XINDataSet XINDataSet;
        private XINDataSetTableAdapters.ReceiptListTableAdapter ReceiptListTableAdapter;
    }
}
