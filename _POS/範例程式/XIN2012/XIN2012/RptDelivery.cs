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
    public partial class fmRptDelivery : XIN2012.fmBasePreviewReport
    {

        //要列印的出貨單號碼
        string FDeliveryID;
        
        public fmRptDelivery()
        {
            InitializeComponent();
        }

        private void fmRptDelivery_Load(object sender, EventArgs e)
        {

        }

        public override void GenerateReport()
        {
            //載入資料
            this.DeliveryTableAdapter.Fill(this.XINDataSet.Delivery, FDeliveryID);
            //建立報表參數
            ReportParameter ReportTitle = new ReportParameter();
            ReportTitle.Name = "ReportTitle";
            //取得查詢結果的第一筆記錄
            DataRow dr = XINDataSet.Tables["Delivery"].Rows[0];
            //取得出貨單的出貨別
            if ((dr["DeliveryType"]).ToString() == "1")
            {
                ReportTitle.Values.Add("出貨單");
            }
            else
            {
                ReportTitle.Values.Add("出貨退回單");
            }
            //將報表參數反映到報表底稿上的報表參數
            this.reportViewerBase.LocalReport.SetParameters(
                                  new ReportParameter[] { ReportTitle });
        }

        //設定要列印的出貨單號碼
        public string DeliveryID
        {
            set
            {
                FDeliveryID = value;
            }
        }
    }
}
