using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace XIN2012
{
    public partial class fmRptDeliveryList : XIN2012.fmBasePreviewReport
    {

        //出貨日期(起)
        DateTime FBeginDate;
        //出貨日期(迄)
        DateTime FEndDate;
        //客戶編號
        string FCustomerID;
        //出貨別
        string FDeliveryType;

        public fmRptDeliveryList()
        {
            InitializeComponent();
        }

        //設定出貨日期(起)
        public DateTime BeginDate
        {
            set
            {
                FBeginDate = value;
            }
        }

        //設定出貨日期(迄)
        public DateTime EndDate
        {
            set
            {
                FEndDate = value;
            }
        }

        //設定客戶編號
        public string CustomerID
        {
            set
            {
                FCustomerID = value;
            }
        }

        //設定出貨別
        public string DeliveryType
        {
            set
            {
                FDeliveryType = value;
            }
        }

        public override void GenerateReport()
        {
            string FBeginCustomerID, FEndCustomerID;
            string strCondi = "單據日期：";
            strCondi = strCondi + FBeginDate.ToShortDateString() + "~" +
                                  FEndDate.ToShortDateString() +
                                  "   客戶：";
            if (FCustomerID == string.Empty)
            {
                FBeginCustomerID = "";
                FEndCustomerID = "ZZZZZZZZ";
                strCondi = strCondi + "全部";
            }
            else
            {
                FBeginCustomerID = FCustomerID;
                FEndCustomerID = FCustomerID;
                strCondi = strCondi + FCustomerID;
            }
            //載入資料
            this.DeliveryListTableAdapter.Fill(this.XINDataSet.DeliveryList,
                                              FBeginDate, FEndDate, FBeginCustomerID,
                                              FEndCustomerID, FDeliveryType);
            //建立報表參數
            ReportParameter ReportTitle = new ReportParameter();
            ReportParameter ReportCondi = new ReportParameter();
            ReportTitle.Name = "ReportTitle";
            ReportCondi.Name = "ReportCondi";
            if (FDeliveryType == "1")
            {
                ReportTitle.Values.Add("出貨明細表");
            }
            else
            {
                ReportTitle.Values.Add("出貨退回明細表");
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
