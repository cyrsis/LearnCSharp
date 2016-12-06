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
    public partial class fmRptTransfer : XIN2012.fmBasePreviewReport
    {

        //要列印的存貨異動單號碼
        string FTransferID;

        public fmRptTransfer()
        {
            InitializeComponent();
        }

        //設定要列印的存貨異動單號碼
        public string TransferID
        {
            set
            {
                FTransferID = value;
            }
        }

        public override void GenerateReport()
        {
            //載入資料
            this.TransferTableAdapter.Fill(this.XINDataSet.Transfer, FTransferID);
            //建立報表參數
            ReportParameter ReportTitle = new ReportParameter();
            ReportTitle.Name = "ReportTitle";
            //取得查詢結果的第一筆記錄
            DataRow dr = XINDataSet.Tables["Transfer"].Rows[0];
            //取得存貨異動單的異動別
            if ((dr["TransferType"]).ToString() == "1")
            {
                ReportTitle.Values.Add("存貨入庫單");
            }
            else
            {
                ReportTitle.Values.Add("存貨出庫單");
            }
            //將報表參數反映到報表底稿上的報表參數
            this.reportViewerBase.LocalReport.SetParameters(
                                  new ReportParameter[] { ReportTitle });
        }
    }
}
