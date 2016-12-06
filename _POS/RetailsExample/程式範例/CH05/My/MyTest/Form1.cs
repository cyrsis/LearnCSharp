using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMy_Click(object sender, EventArgs e)
        {
            string MyPCName = My.Computer.Name;
            MessageBox.Show("電腦名稱:" + MyPCName,"My");
        }

        private void btnMyString_Click(object sender, EventArgs e)
        {
            string SN = "ABCD-EFGH-ZYTW";
            MessageBox.Show(My.MyString.toRidSpecChar(SN, "-"), "MyString");
        }
    }
}
