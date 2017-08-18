using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Split_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string Customer = "C1030001-新蛋科技";
            string CustomerCode = Customer.Split('-')[0];
            string CustomerName = Customer.Split('-')[1];
            string msg = "客戶編號:" + CustomerCode + "\n" +
                "客戶名稱:" + CustomerName;
            MessageBox.Show(msg, "Split()方法");
        }
    }
}
