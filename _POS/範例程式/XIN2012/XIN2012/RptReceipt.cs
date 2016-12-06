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
    public partial class fmRptReceipt : XIN2012.fmBasePreviewReport
    {
      
        //要列印的進貨單號碼
        string FReceiptID;
        
        public fmRptReceipt()
        {
            InitializeComponent();
        }

        public override void GenerateReport()
        {
            //載入資料
            this.ReceiptTableAdapter.Fill(this.XINDataSet.Receipt, FReceiptID);
            //建立報表參數
            ReportParameter ReportTitle = new ReportParameter();
            ReportTitle.Name = "ReportTitle";
            //取得查詢結果的第一筆記錄
            DataRow dr = XINDataSet.Tables["Receipt"].Rows[0];
            //取得進貨單的進貨別
            if ((dr["ReceiptType"]).ToString() == "1")
            {
                ReportTitle.Values.Add("進貨單");
            }
            else
            {
                ReportTitle.Values.Add("進貨退出單");
            }
            //將報表參數反映到報表底稿上的報表參數
            this.reportViewerBase.LocalReport.SetParameters(
                                  new ReportParameter[] { ReportTitle });
        }

        //設定要列印的進貨單號碼
        public string ReceiptID
        {
            set
            {
                FReceiptID = value;
            }
        }

    }
}
