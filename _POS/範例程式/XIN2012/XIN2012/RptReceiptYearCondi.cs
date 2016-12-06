using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XIN2012
{
    public partial class fmRptReceiptYearCondi : XIN2012.fmBaseDialog
    {
        public fmRptReceiptYearCondi()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            fmRptReceiptYear RptReceiptYear = new fmRptReceiptYear();
            //進貨年度
            RptReceiptYear.Year = Convert.ToInt32(numericUpDown1.Value);
            RptReceiptYear.MdiParent = this.ParentForm;
            //顯示報表
            RptReceiptYear.Show();
            //允許關閉此對話方塊
            CanClose = true;
            //關閉此對話方塊
            this.Close();
        }

        private void fmRptReceiptYearCondi_Load(object sender, EventArgs e)
        {
            //以系統日期的年度當預設值
            numericUpDown1.Value = Convert.ToDateTime(DateTime.Today).Year;
        }
    }
}
