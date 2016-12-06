using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XIN2012
{
    public partial class fmRptStockPostGroupCondi : XIN2012.fmBaseDialog
    {
        public fmRptStockPostGroupCondi()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            fmRptStockPostGroup RptStockPostGroup = new fmRptStockPostGroup();
            //異動日期(起)
            RptStockPostGroup.BeginDate = Convert.ToDateTime(
                                                  BeginDate.Value.ToShortDateString());
            //異動日期(迄)
            RptStockPostGroup.EndDate = Convert.ToDateTime(
                                                EndDate.Value.ToShortDateString());
            RptStockPostGroup.MdiParent = this.ParentForm;
            //顯示報表
            RptStockPostGroup.Show();
            //允許關閉此對話方塊
            CanClose = true;
            //關閉此對話方塊
            this.Close();
        }
    }
}
