using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XIN2012
{
    public partial class fmRptReceiptRankCondi : XIN2012.fmBaseDialog
    {
        public fmRptReceiptRankCondi()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            fmRptReceiptRank RptReceiptRank = new fmRptReceiptRank();
            //進貨日期(起)
            RptReceiptRank.BeginDate = Convert.ToDateTime
                                        (BeginDate.Value.ToShortDateString());
            //進貨日期(迄)
            RptReceiptRank.EndDate = Convert.ToDateTime(
                                      EndDate.Value.ToShortDateString());
            RptReceiptRank.MdiParent = this.ParentForm;
            RptReceiptRank.Show();
            CanClose = true;
            this.Close();
        }
    }
}
