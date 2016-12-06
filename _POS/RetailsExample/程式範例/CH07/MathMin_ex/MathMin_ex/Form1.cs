using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathMin_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int n = 5;
            int m = 10;
            string msg = string.Format("n = {0}, m = {1} 二數最小值為 {2}", n, m, Math.Min(n, m));
            MessageBox.Show(msg, "Math.Min");
        }
    }
}
