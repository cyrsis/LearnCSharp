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
namespace SaleOrdersReport_ex
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
            dtpStartDate.Text = "2014年01月01日";
            ReloadReport("rptSaleOrders", "%", "2014年01月01日", DateTime.Now.ToString("yyyy年MM月dd日"));
        }

        private void ReloadReport(string ReportName, string searchKeyValue, string StartDate, string EndDate)
        {
            try
            {
                ReportDataSource rptDataSource = new ReportDataSource();
                ReportParameter[] Parms = new ReportParameter[2];
                Parms[0] = new ReportParameter("rpCompanyName", "龍科技(Dragon Technology)"); //需在Report參數新增CompanyName
                Parms[1] = new ReportParameter("rpBusinessTax", "6");

                strReport = ReportName;
                reportViewer1.LocalReport.ReportPath = Application.StartupPath + "\\" + strReport + ".rdlc";
                reportViewer1.LocalReport.SetParameters(Parms); //需定義於ReportPath之後
                reportViewer1.LocalReport.DataSources.Clear();

                DataSetSaleOrders ds = new DataSetSaleOrders();
                DataSetSaleOrdersTableAdapters.ShipDetailsTableAdapter da = new DataSetSaleOrdersTableAdapters.ShipDetailsTableAdapter();
                da.Fill(ds.ShipDetails, searchKeyValue, StartDate, EndDate);
                rptDataSource = new ReportDataSource("DataSet1", ds.Tables["ShipDetails"]);

                if (this.reportViewer1.LocalReport.DataSources.Count > 0)
                {
                    this.reportViewer1.LocalReport.DataSources.RemoveAt(0);
                }

                this.reportViewer1.LocalReport.DataSources.Add(rptDataSource);
                this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            this.reportViewer1.RefreshReport();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string SearchKey = "%" + txtSearchKeyword.Text + "%";
            string StartDate = dtpStartDate.Value.ToString("yyyy年MM月dd日");
            string EndDate = dtpEndDate.Value.ToString("yyyy年MM月dd日");
            ReloadReport("rptSaleOrders", SearchKey, StartDate, EndDate);
        }

    }
}
