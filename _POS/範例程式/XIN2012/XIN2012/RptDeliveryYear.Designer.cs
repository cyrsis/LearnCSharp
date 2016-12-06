namespace XIN2012
{
    partial class fmRptDeliveryYear
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
            this.DeliveryYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.XINDataSet = new XIN2012.XINDataSet();
            this.DeliveryYearTableAdapter = new XIN2012.XINDataSetTableAdapters.DeliveryYearTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XINDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerBase
            // 
            this.reportViewerBase.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDeliveryYear";
            reportDataSource1.Value = this.DeliveryYearBindingSource;
            this.reportViewerBase.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerBase.LocalReport.DisplayName = "BasePreviewReport";
            this.reportViewerBase.LocalReport.ReportEmbeddedResource = "XIN2012.RptDeliveryYear.rdlc";
            this.reportViewerBase.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBase.Size = new System.Drawing.Size(594, 241);
            // 
            // DeliveryYearBindingSource
            // 
            this.DeliveryYearBindingSource.DataMember = "DeliveryYear";
            this.DeliveryYearBindingSource.DataSource = this.XINDataSet;
            // 
            // XINDataSet
            // 
            this.XINDataSet.DataSetName = "XINDataSet";
            this.XINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DeliveryYearTableAdapter
            // 
            this.DeliveryYearTableAdapter.ClearBeforeFill = true;
            // 
            // fmRptDeliveryYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(594, 241);
            this.Name = "fmRptDeliveryYear";
            this.Text = "出貨年統計表";
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XINDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource DeliveryYearBindingSource;
        private XINDataSet XINDataSet;
        private XINDataSetTableAdapters.DeliveryYearTableAdapter DeliveryYearTableAdapter;



    }
}
