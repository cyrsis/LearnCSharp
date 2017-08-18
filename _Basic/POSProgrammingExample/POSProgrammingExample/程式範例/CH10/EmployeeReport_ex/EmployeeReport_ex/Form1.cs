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
namespace EmployeeReport_ex
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
            ReloadReport("rptEmployee");
        }
        private void ReloadReport(string ReportName)
        {
            ReportDataSource rptDataSource = new ReportDataSource();
            strReport = ReportName;
            try
            {
                reportViewer1.LocalReport.ReportPath = Application.StartupPath + "\\" + strReport + ".rdlc";
                reportViewer1.LocalReport.DataSources.Clear();

                DataSetEmployee ds = new DataSetEmployee();
                DataSetEmployeeTableAdapters.EmployeeInfoTableAdapter da =
                    new DataSetEmployeeTableAdapters.EmployeeInfoTableAdapter();
                da.Fill(ds.EmployeeInfo ,"許清榮");
                rptDataSource = new ReportDataSource("DataSet1", ds.Tables["EmployeeInfo"]);
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
