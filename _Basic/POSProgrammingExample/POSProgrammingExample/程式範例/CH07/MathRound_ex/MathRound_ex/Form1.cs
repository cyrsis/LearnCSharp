using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathRound_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            double x = 100.4;
            double y = 100.5;
            double x1 = Math.Round(x,0, MidpointRounding.AwayFromZero);//四捨五入
            double y1 = Math.Round(y, 0, MidpointRounding.AwayFromZero);//四捨五入
            string msg = string.Format("x={0} , y={1}  \n x1={2} , y1={3} " , 
                x , y ,  x1 , y1 );
            MessageBox.Show(msg, "Math.Round");
        }
    }
}
