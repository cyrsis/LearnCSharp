using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.Reporting.WinForms;

namespace XIN2012
{
    public partial class fmRptDullSales : XIN2012.fmBasePreviewReport
    {

        //參考日期
        DateTime FRefrenceDate;

        public fmRptDullSales()
        {
            InitializeComponent();
        }

        //設定參考日期
        public DateTime RefrenceDate
        {
            set
            {
                FRefrenceDate = value;
            }
        }

        public override void GenerateReport()
        {
            try
            {
                using (var context = new XINEntities())
                {
                    var qry = from P in context.Product
                              where P.LastDeliveryDate <= FRefrenceDate &&
                              P.Stock > 0
                              orderby P.ProductID
                              select P;
                    ProductBindingSource.DataSource = qry;
                }
                //建立報表參數
                ReportParameter ReportCondi = new ReportParameter();
                ReportCondi.Name = "ReportCondi";
                ReportCondi.Values.Add("參考日期：" + FRefrenceDate.ToShortDateString());
                //將報表參數反映到報表底稿上的報表參數
                this.reportViewerBase.LocalReport.SetParameters(
                                      new ReportParameter[] { ReportCondi });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
