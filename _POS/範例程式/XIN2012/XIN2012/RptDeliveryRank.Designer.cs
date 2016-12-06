namespace XIN2012
{
    partial class fmRptDeliveryRank
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
            this.DeliveryRankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeliveryRankTableAdapter = new XIN2012.XINDataSetTableAdapters.DeliveryRankTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.XINDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryRankBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerBase
            // 
            this.reportViewerBase.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDeliveryRank";
            reportDataSource1.Value = this.DeliveryRankBindingSource;
            this.reportViewerBase.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerBase.LocalReport.DisplayName = "BasePreviewReport";
            this.reportViewerBase.LocalReport.ReportEmbeddedResource = "XIN2012.RptDeliveryRank.rdlc";
            this.reportViewerBase.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBase.Size = new System.Drawing.Size(515, 263);
            // 
            // XINDataSet
            // 
            this.XINDataSet.DataSetName = "XINDataSet";
            this.XINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DeliveryRankBindingSource
            // 
            this.DeliveryRankBindingSource.DataMember = "DeliveryRank";
            this.DeliveryRankBindingSource.DataSource = this.XINDataSet;
            // 
            // DeliveryRankTableAdapter
            // 
            this.DeliveryRankTableAdapter.ClearBeforeFill = true;
            // 
            // fmRptDeliveryRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(515, 263);
            this.Name = "fmRptDeliveryRank";
            this.Text = "出貨排行榜";
            ((System.ComponentModel.ISupportInitialize)(this.XINDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryRankBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource DeliveryRankBindingSource;
        private XINDataSet XINDataSet;
        private XINDataSetTableAdapters.DeliveryRankTableAdapter DeliveryRankTableAdapter;
    }
}
