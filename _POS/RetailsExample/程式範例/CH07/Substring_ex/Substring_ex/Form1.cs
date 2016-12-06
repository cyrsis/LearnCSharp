using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Substring_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
            string Manufacturer = "Newegg-新蛋科技";

            string ManufacturerID = Manufacturer.Substring(0, Manufacturer.IndexOf("-"));

            string msg = "廠商英文名稱:" + ManufacturerID ;
            MessageBox.Show(msg, "Substring()方法");
        }
    }
}
