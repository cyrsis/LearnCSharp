using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompareTo_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompareTo_Click(object sender, EventArgs e)
        {
            string s1 = "these";
            string s2 = "those";
            string msg = "s1 =" + s1 + ",s2=" + s2 + "\n";
            int result = s1.CompareTo(s2);

            if (result == 0)
            {
                msg = msg + "字串相等,結果為[" + result + "]\n";
            }
            else if (result == -1)
            {
                msg = msg + s1 + "小於" + s2 + ",結果為[" + result + "]\n";
            }
            else if (result == 1)
            {
                msg = msg + s1 + "大於" + s2 + ",結果為[" + result + "]\n";
            }
            MessageBox.Show(msg, "CompareTo()方法");
        }
    }
}
