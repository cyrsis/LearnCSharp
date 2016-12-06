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
    public partial class fmRptDeliveryGroup : XIN2012.fmBasePreviewReport
    {

        //出貨日期(起)
        DateTime FBeginDate;
        //出貨日期(迄)
        DateTime FEndDate;
        //客戶編號
        string FCustomerID;
        //商品編號
        string FProductID;

        public fmRptDeliveryGroup()
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
            string FBeginCustomerID, FEndCustomerID;
            string FBeginProductID, FEndProductID;
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
            strCondi = strCondi + "  商品";
            if (FProductID == string.Empty)
            {
                FBeginProductID = "";
                FEndProductID = "ZZZZZZZZZZ";
                strCondi = strCondi + "全部：";
            }
            else
            {
                FBeginProductID = FProductID;
                FEndProductID = FProductID;
                strCondi = strCondi + FProductID;
            }
            //載入資料
            this.DeliveryGroupTableAdapter.Fill(this.XINDataSet.DeliveryGroup,
                                    FBeginDate, FEndDate, FBeginCustomerID,
                                    FEndCustomerID, FBeginProductID, FEndProductID);
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
