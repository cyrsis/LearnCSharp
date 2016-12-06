namespace XIN2012
{
    partial class fmRptDeliveryList
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
            this.DeliveryListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeliveryListTableAdapter = new XIN2012.XINDataSetTableAdapters.DeliveryListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.XINDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerBase
            // 
            this.reportViewerBase.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDeliveryList";
            reportDataSource1.Value = this.DeliveryListBindingSource;
            this.reportViewerBase.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerBase.LocalReport.DisplayName = "BasePreviewReport";
            this.reportViewerBase.LocalReport.ReportEmbeddedResource = "XIN2012.RptDeliveryList.rdlc";
            this.reportViewerBase.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBase.Size = new System.Drawing.Size(673, 268);
            // 
            // XINDataSet
            // 
            this.XINDataSet.DataSetName = "XINDataSet";
            this.XINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DeliveryListBindingSource
            // 
            this.DeliveryListBindingSource.DataMember = "DeliveryList";
            this.DeliveryListBindingSource.DataSource = this.XINDataSet;
            // 
            // DeliveryListTableAdapter
            // 
            this.DeliveryListTableAdapter.ClearBeforeFill = true;
            // 
            // fmRptDeliveryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(673, 268);
            this.Name = "fmRptDeliveryList";
            this.Text = "出貨（退回）明細表";
            ((System.ComponentModel.ISupportInitialize)(this.XINDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XINDataSet XINDataSet;
        private System.Windows.Forms.BindingSource DeliveryListBindingSource;
        private XINDataSetTableAdapters.DeliveryListTableAdapter DeliveryListTableAdapter;
    }
}
