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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            frmReportPrint rptCustomer = new frmReportPrint(@"C:\rptCustomer.rdlc","客戶明細表");
            rptCustomer.ShowDialog();
        }

        private void btnManufacturerDetails_Click(object sender, EventArgs e)
        {
            frmReportPrint rptManufacturer = new frmReportPrint(@"C:\rptManufacturer.rdlc", "廠商明細表");
            rptManufacturer.ShowDialog();
        }
    }
}
