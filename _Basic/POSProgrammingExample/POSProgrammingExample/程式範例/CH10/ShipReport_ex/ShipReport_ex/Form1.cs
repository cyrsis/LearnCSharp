using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;//new
namespace ShipReport_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string strReport { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadReport("rptShipMaster");
        }
        private void ReloadReport(string ReportName)
        {
            ReportDataSource rptDataSource = new ReportDataSource();
            strReport = ReportName;
            try
            {
                reportViewer1.LocalReport.ReportPath = Application.StartupPath + "\\" + strReport + ".rdlc";
                reportViewer1.LocalReport.DataSources.Clear();

                DataSetShipMaster ds = new DataSetShipMaster();
                DataSetShipMasterTableAdapters.ShipMasterTableAdapter da =
                    new DataSetShipMasterTableAdapters.ShipMasterTableAdapter();
                reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SetSubDataSource);
                da.Fill(ds.ShipMaster, "SH1030212225935");
                rptDataSource = new ReportDataSource("DataSet1", ds.Tables["ShipMaster"]);
                this.reportViewer1.LocalReport.DataSources.Add(rptDataSource);
                this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            this.reportViewer1.RefreshReport();
        }
        public void SetSubDataSource(object sender, SubreportProcessingEventArgs e)
        {
            DataSetShipDetails ds = new DataSetShipDetails();
            DataSetShipDetailsTableAdapters.ShipDetailsTableAdapter da = 
                new DataSetShipDetailsTableAdapters.ShipDetailsTableAdapter();
            da.Fill(ds.ShipDetails, e.Parameters["rpShipID"].Values[0]);

            e.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables["ShipDetails"]));
        }

    }
}
