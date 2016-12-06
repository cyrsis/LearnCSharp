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
    public partial class fmRptReceiptGroup : XIN2012.fmBasePreviewReport
    {

        //進貨日期(起)
        DateTime FBeginDate;
        //進貨日期(迄)
        DateTime FEndDate;
        //廠商編號
        string FSupplierID;
        //商品編號
        string FProductID;

        public fmRptReceiptGroup()
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

        //設定商品編號
        public string ProductID
        {
            set
            {
                FProductID = value;
            }
        }

        public override void GenerateReport()
        {
            string FBeginSupplierID, FEndSupplierID;
            string FBeginProductID, FEndProductID;
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
            strCondi = strCondi + "  商品：";
            if (FProductID == string.Empty)
            {
                FBeginProductID = "";
                FEndProductID = "ZZZZZZZZZZ";
                strCondi = strCondi + "全部";
            }
            else
            {
                FBeginProductID = FProductID;
                FEndProductID = FProductID;
                strCondi = strCondi + FProductID;
            }
            //載入資料
            this.ReceiptGroupTableAdapter.Fill(this.XINDataSet.ReceiptGroup,
                                              FBeginDate, FEndDate, FBeginSupplierID,
                                              FEndSupplierID, FBeginProductID, FEndProductID);
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
