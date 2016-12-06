using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTruncate_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            double x = 10.125;
            double y = 10.527;
            double x1 = Math.Truncate(x);
            double y1 = Math.Truncate(y);
            string msg = string.Format("x={0} , y={1}  \n x1={2} , y1={3} ",
                x, y, x1, y1);
            MessageBox.Show(msg, "Math.Truncate");
        }
    }
}
