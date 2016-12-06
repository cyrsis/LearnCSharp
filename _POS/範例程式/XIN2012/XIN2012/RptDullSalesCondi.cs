using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XIN2012
{
    public partial class fmRptDullSalesCondi : XIN2012.fmBaseDialog
    {
        public fmRptDullSalesCondi()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            fmRptDullSales RptDullSales = new fmRptDullSales();
            //參考日期
            RptDullSales.RefrenceDate = Convert.ToDateTime(
                                                RefrenceDate.Value.ToShortDateString());
            RptDullSales.MdiParent = this.ParentForm;
            //顯示報表畫面
            RptDullSales.Show();
            //允許關閉此視窗
            CanClose = true;
            //關閉此視窗
            this.Close();
        }
    }
}
