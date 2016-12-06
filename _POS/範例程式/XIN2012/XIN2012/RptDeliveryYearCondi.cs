using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XIN2012
{
    public partial class fmRptDeliveryYearCondi : XIN2012.fmBaseDialog
    {
        public fmRptDeliveryYearCondi()
        {
            InitializeComponent();
        }

        private void fmRptDeliveryYearCondi_Load(object sender, EventArgs e)
        {
            //以系統日期的年度當預設值
            numericUpDown1.Value = Convert.ToDateTime(DateTime.Today).Year;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            fmRptDeliveryYear RptDeliveryYear = new fmRptDeliveryYear();
            //出貨年度
            RptDeliveryYear.Year = Convert.ToInt32(numericUpDown1.Value);
            RptDeliveryYear.MdiParent = this.ParentForm;
            //顯示報表
            RptDeliveryYear.Show();
            //允許關閉此對話方塊
            CanClose = true;
            //關閉此對話方塊
            this.Close();
        }
    }
}
