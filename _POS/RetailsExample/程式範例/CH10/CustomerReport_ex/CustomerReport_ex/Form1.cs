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
namespace CustomerReport_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public string strReport { get; set; }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            ReloadReport("rptCustomer");
        }
        private void ReloadReport(string ReportName)
        {
            ReportDataSource rptDataSource = new ReportDataSource();
            strReport = ReportName;
            try
            {
                reportViewer1.LocalReport.ReportPath = Application.StartupPath + "\\" + strReport + ".rdlc";
                reportViewer1.LocalReport.DataSources.Clear();

                DataSetCustomer ds= new DataSetCustomer();
                DataSetCustomerTableAdapters.CustomerInfoTableAdapter da = 
                    new DataSetCustomerTableAdapters.CustomerInfoTableAdapter();
                da.Fill(ds.CustomerInfo);
                rptDataSource = new ReportDataSource("DataSet1", ds.Tables["CustomerInfo"]);
                this.reportViewer1.LocalReport.DataSources.Add(rptDataSource);
                this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
