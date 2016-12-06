namespace XIN2012
{
    partial class fmRptDelivery
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
            this.XINDataSet = new XIN2012.XINDataSet();
            this.DeliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeliveryTableAdapter = new XIN2012.XINDataSetTableAdapters.DeliveryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.XINDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerBase
            // 
            this.reportViewerBase.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDelivery";
            reportDataSource1.Value = this.DeliveryBindingSource;
            this.reportViewerBase.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerBase.LocalReport.DisplayName = "BasePreviewReport";
            this.reportViewerBase.LocalReport.ReportEmbeddedResource = "XIN2012.RptDelivery.rdlc";
            this.reportViewerBase.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBase.Size = new System.Drawing.Size(669, 412);
            // 
            // XINDataSet
            // 
            this.XINDataSet.DataSetName = "XINDataSet";
            this.XINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DeliveryBindingSource
            // 
            this.DeliveryBindingSource.DataMember = "Delivery";
            this.DeliveryBindingSource.DataSource = this.XINDataSet;
            // 
            // DeliveryTableAdapter
            // 
            this.DeliveryTableAdapter.ClearBeforeFill = true;
            // 
            // fmRptDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(669, 412);
            this.Name = "fmRptDelivery";
            this.Text = "出貨（退回）單";
            this.Load += new System.EventHandler(this.fmRptDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XINDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource DeliveryBindingSource;
        private XINDataSet XINDataSet;
        private XINDataSetTableAdapters.DeliveryTableAdapter DeliveryTableAdapter;
    }
}
