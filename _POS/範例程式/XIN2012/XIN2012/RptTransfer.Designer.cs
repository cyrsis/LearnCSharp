namespace XIN2012
{
    partial class fmRptTransfer
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
            this.TransferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.XINDataSet = new XIN2012.XINDataSet();
            this.TransferTableAdapter = new XIN2012.XINDataSetTableAdapters.TransferTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TransferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XINDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerBase
            // 
            this.reportViewerBase.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetTransfer";
            reportDataSource2.Value = this.TransferBindingSource;
            this.reportViewerBase.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerBase.LocalReport.DisplayName = "BasePreviewReport";
            this.reportViewerBase.LocalReport.ReportEmbeddedResource = "XIN2012.RptTransfer.rdlc";
            this.reportViewerBase.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBase.Size = new System.Drawing.Size(607, 269);
            // 
            // TransferBindingSource
            // 
            this.TransferBindingSource.DataMember = "Transfer";
            this.TransferBindingSource.DataSource = this.XINDataSet;
            // 
            // XINDataSet
            // 
            this.XINDataSet.DataSetName = "XINDataSet";
            this.XINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TransferTableAdapter
            // 
            this.TransferTableAdapter.ClearBeforeFill = true;
            // 
            // fmRptTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(607, 269);
            this.Name = "fmRptTransfer";
            this.Text = "存貨異動單";
            ((System.ComponentModel.ISupportInitialize)(this.TransferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XINDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource TransferBindingSource;
        private XINDataSet XINDataSet;
        private XINDataSetTableAdapters.TransferTableAdapter TransferTableAdapter;
    }
}
