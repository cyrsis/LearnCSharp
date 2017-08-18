using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndexOf_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            string msg = "E103012-許清榮";
            string key = "-";

            int index = msg.IndexOf(key);

            MessageBox.Show(msg + "\n的[" + key
                + "]索引位置=" + index.ToString());
        }
    }
}
