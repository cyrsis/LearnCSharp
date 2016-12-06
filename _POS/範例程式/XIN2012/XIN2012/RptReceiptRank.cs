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
    public partial class fmRptReceiptRank : XIN2012.fmBasePreviewReport
    {

        //進貨日期(起)
        DateTime FBeginDate;
        //進貨日期(迄)
        DateTime FEndDate;

        public fmRptReceiptRank()
        {
            InitializeComponent();
        }

        //設定進貨日期(起)
        public DateTime BeginDate
        {
            set
            {
                FBeginDate = value;
            }
        }
        
        //設定進貨日期(迄)
        public DateTime EndDate
        {
            set
            {
                FEndDate = value;
            }
        }
        
        public override void GenerateReport()
        {
            string strCondi;
            strCondi = "單據日期：" + 
                       FBeginDate.ToShortDateString() + "~" +
                       FEndDate.ToShortDateString();
            //載入資料
            this.ReceiptRankTableAdapter.Fill(this.XINDataSet.ReceiptRank,
                                        FBeginDate, FEndDate);
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
