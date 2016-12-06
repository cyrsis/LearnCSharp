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
    public partial class fmForm2 : Form
    {
        public fmForm2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'XINDataSet.Customer' 資料表。您可以視需要進行移動或移除。
            this.CustomerTableAdapter.Fill(this.XINDataSet.Customer);

            ReportParameter PCOMP = new ReportParameter();
            PCOMP.Name = "PCOMP";
            PCOMP.Values.Add("AAA-BBB");

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { PCOMP });
            this.reportViewer1.RefreshReport();
        }
    }
}
