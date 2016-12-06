using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace XIN2012
{
    public partial class fmRptReceiptYear : XIN2012.fmBasePreviewReport
    {

        //進貨年度
        Int32 FYear;

        public fmRptReceiptYear()
        {
            InitializeComponent();
        }

        //設定進貨年度
        public Int32 Year
        {
            set
            {
                FYear = value;
            }
        }

        public override void GenerateReport()
        {
            string strCondi = "年度：" + FYear.ToString();
            //載入資料
            this.ReceiptYearTableAdapter.Fill(this.XINDataSet.ReceiptYear, FYear);
            //建立報表參數
            ReportParameter ReportCondi = new ReportParameter();
            ReportCondi.Name = "ReportCondi";
            ReportCondi.Values.Add(strCondi);
            //將報表參數反映到報表底稿上的報表參數
            this.reportViewerBase.LocalReport.SetParameters(
                                          new ReportParameter[] { ReportCondi });
        }

    }
}
