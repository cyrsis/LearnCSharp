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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.XINDataSet = new XIN2012.XINDataSet();
            this.ReceiptListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReceiptListTableAdapter = new XIN2012.XINDataSetTableAdapters.ReceiptListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.XINDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerBase
            // 
            this.reportViewerBase.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetReceiptList";
            reportDataSource2.Value = this.ReceiptListBindingSource;
            this.reportViewerBase.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerBase.LocalReport.DisplayName = "BasePreviewReport";
            this.reportViewerBase.LocalReport.ReportEmbeddedResource = "XIN2012.RptReceiptList.rdlc";
            this.reportViewerBase.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBase.Size = new System.Drawing.Size(821, 449);
            // 
            // XINDataSet
            // 
            this.XINDataSet.DataSetName = "XINDataSet";
            this.XINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReceiptListBindingSource
            // 
            this.ReceiptListBindingSource.DataMember = "ReceiptList";
            this.ReceiptListBindingSource.DataSource = this.XINDataSet;
            // 
            // ReceiptListTableAdapter
            // 
            this.ReceiptListTableAdapter.ClearBeforeFill = true;
            // 
            // fmRptReceiptList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(821, 449);
            this.Name = "fmRptReceiptList";
            this.Text = "進貨（退出）明細表";
            this.Load += new System.EventHandler(this.fmReceiptList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XINDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ReceiptListBindingSource;
        private XINDataSet XINDataSet;
        private XINDataSetTableAdapters.ReceiptListTableAdapter ReceiptListTableAdapter;
    }
}
