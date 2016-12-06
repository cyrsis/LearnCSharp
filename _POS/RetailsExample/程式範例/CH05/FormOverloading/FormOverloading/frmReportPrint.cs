using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormOverloading
{
    public partial class frmReportPrint : Form
    {
        public frmReportPrint()
        {
            InitializeComponent();
        }
        private string ReportFilePath;
        public frmReportPrint(string reportFilePath , string reportTitle)
        {
            InitializeComponent();
            this.Text = reportTitle;
            this.ReportFilePath = reportFilePath;
        }

        private void btnReportPath_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ReportFilePath, "報表路徑");
        }
    }
}
