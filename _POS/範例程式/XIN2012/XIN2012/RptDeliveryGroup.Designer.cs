namespace XIN2012
{
    partial class fmRptDeliveryGroup
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
            this.DeliveryGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.XINDataSet = new XIN2012.XINDataSet();            
            this.DeliveryGroupTableAdapter = new XIN2012.XINDataSetTableAdapters.DeliveryGroupTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.XINDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryGroupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerBase
            // 
            this.reportViewerBase.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDeliveryGroup";
            reportDataSource1.Value = this.DeliveryGroupBindingSource;
            this.reportViewerBase.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerBase.LocalReport.DisplayName = "BasePreviewReport";
            this.reportViewerBase.LocalReport.ReportEmbeddedResource = "XIN2012.RptDeliveryGroup.rdlc";
            this.reportViewerBase.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBase.Size = new System.Drawing.Size(615, 306);
            // 
            // XINDataSet
            // 
            this.XINDataSet.DataSetName = "XINDataSet";
            this.XINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DeliveryGroupBindingSource
            // 
            this.DeliveryGroupBindingSource.DataMember = "DeliveryGroup";
            this.DeliveryGroupBindingSource.DataSource = this.XINDataSet;
            // 
            // DeliveryGroupTableAdapter
            // 
            this.DeliveryGroupTableAdapter.ClearBeforeFill = true;
            // 
            // fmRptDeliveryGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(615, 306);
            this.Name = "fmRptDeliveryGroup";
            this.Text = "出貨統計表";
            ((System.ComponentModel.ISupportInitialize)(this.XINDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryGroupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource DeliveryGroupBindingSource;
        private XINDataSet XINDataSet;
        private XINDataSetTableAdapters.DeliveryGroupTableAdapter DeliveryGroupTableAdapter;
    }
}
