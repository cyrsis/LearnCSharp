using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace XIN2012
{
    public partial class fmBasePreviewReport : Form
    {
        public fmBasePreviewReport()
        {
            InitializeComponent();
        }

        private void fmBasePreviewReport_Load(object sender, EventArgs e)
        {
            //以整頁模式顯示報表
            this.reportViewerBase.SetDisplayMode(DisplayMode.PrintLayout);
            //切換縮放方式為百分比
            this.reportViewerBase.ZoomMode = ZoomMode.Percent;
            //顯示比例為100%
            this.reportViewerBase.ZoomPercent = 100;
            //讓ReportView控制項停駐於父容器中
            this.reportViewerBase.Dock = DockStyle.Fill;
            //以視窗的Text屬性作為報表的名稱
            this.reportViewerBase.LocalReport.DisplayName = this.Text;
            //視窗位置
            this.Left = 0;
            this.Top = 0;
            //視窗大小
            this.Width = this.Parent.ClientSize.Width;
            this.Height = this.Parent.ClientSize.Height;
            //產生報表所需的資料
            GenerateReport();
            //處理和轉譯 [報表檢視器] 中的目前報表
            this.reportViewerBase.RefreshReport();
        }

        public virtual void GenerateReport()
        {
            //虛擬方法，供繼承者實作
            //產生報表的內容
        }
    }
}
