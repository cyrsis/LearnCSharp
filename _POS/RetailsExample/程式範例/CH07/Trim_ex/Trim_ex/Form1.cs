using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trim_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            string searchKey = "  Epson  ";
            int n1 = searchKey.Length;

            string searchKeyTrim = searchKey.Trim();

            int n2 = searchKeyTrim.Length;
            string msg = "原字串:[" + searchKey + "],字串長度=" + n1 + "\n";
            msg = msg + "去空白:[" + searchKeyTrim + "],字串長度= " + n2;
            MessageBox.Show(msg, "Trim()方法");
        }
    }
}
