using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XIN2012
{
    public partial class fmRptReceiptList : XIN2012.fmBasePreviewReport
    {
        public fmRptReceiptList()
        {
            InitializeComponent();
        }

        private void fmReceiptList_Load(object sender, EventArgs e)
        {


        }

        public override void GenerateReport()
        {
            base.GenerateReport();
            // TODO: 這行程式碼會將資料載入 'XINDataSet.ReceiptList' 資料表。您可以視需要進行移動或移除。
            this.ReceiptListTableAdapter.Fill(this.XINDataSet.ReceiptList);
        }
    }
}
