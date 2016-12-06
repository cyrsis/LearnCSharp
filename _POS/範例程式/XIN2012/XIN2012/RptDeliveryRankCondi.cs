using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XIN2012
{
    public partial class fmRptDeliveryRankCondi : XIN2012.fmBaseDialog
    {
        public fmRptDeliveryRankCondi()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            fmRptDeliveryRank RptDeliveryRank = new fmRptDeliveryRank();
            //出貨日期(起)
            RptDeliveryRank.BeginDate = Convert.ToDateTime(
                                               BeginDate.Value.ToShortDateString());
            //出貨日期(迄)
            RptDeliveryRank.EndDate = Convert.ToDateTime(
                                             EndDate.Value.ToShortDateString());
            RptDeliveryRank.MdiParent = this.ParentForm;
            RptDeliveryRank.Show();
            CanClose = true;
            this.Close();
        }
    }
}
