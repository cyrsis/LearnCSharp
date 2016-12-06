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
    public partial class fmRptReceiptList : XIN2012.fmBasePreviewReport
    {
        //進貨日期(起)
        DateTime FBeginDate;
        //進貨日期(迄)
        DateTime FEndDate;
        //廠商編號
        string FSupplierID;
        //進貨別
        string FReceiptType;
 
        public fmRptReceiptList()
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

        //設定廠商編號
        public string SupplierID
        {
            set
            {
                FSupplierID = value;
            }
        }

        //設定進貨別
        public string ReceiptType
        {
            set
            {
                FReceiptType = value;
            }
        }

        public override void GenerateReport()
        {
            string FBeginSupplierID, FEndSupplierID;
            string strCondi = "單據日期：";
            strCondi = strCondi + FBeginDate.ToShortDateString() + "~" +
                                  FEndDate.ToShortDateString() + 
                                  "   廠商：";
            if (FSupplierID == string.Empty)
            {
                FBeginSupplierID = "";
                FEndSupplierID = "ZZZZZZZZ";
                strCondi = strCondi + "全部";
            }
            else
            {
                FBeginSupplierID = FSupplierID;
                FEndSupplierID = FSupplierID;
                strCondi = strCondi + FSupplierID;
            }
            //載入資料
            this.ReceiptListTableAdapter.Fill(this.XINDataSet.ReceiptList,
                                              FBeginDate, FEndDate, FBeginSupplierID, 
                                              FEndSupplierID, FReceiptType);
            //建立報表參數
            ReportParameter ReportTitle = new ReportParameter();
            ReportParameter ReportCondi = new ReportParameter();
            ReportTitle.Name = "ReportTitle";
            ReportCondi.Name = "ReportCondi";
            if (FReceiptType == "1")
            {
                ReportTitle.Values.Add("進貨明細表");
            }
            else
            {
                ReportTitle.Values.Add("進貨退出明細表");
            }
            ReportCondi.Values.Add(strCondi);
            //將報表參數反映到報表底稿上的報表參數
            this.reportViewerBase.LocalReport.SetParameters(
                                  new ReportParameter[] { ReportTitle });
            this.reportViewerBase.LocalReport.SetParameters(
                                  new ReportParameter[] { ReportCondi });
        }
    }
}
