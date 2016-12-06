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
    public partial class fmRptDeliveryYear : XIN2012.fmBasePreviewReport
    {

        //出貨年度
        Int32 FYear;

        public fmRptDeliveryYear()
        {
            InitializeComponent();
        }

        //設定出貨年度
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
            this.DeliveryYearTableAdapter.Fill(this.XINDataSet.DeliveryYear, FYear);
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
