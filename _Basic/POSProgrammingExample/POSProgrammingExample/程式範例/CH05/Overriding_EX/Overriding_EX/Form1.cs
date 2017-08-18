using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overriding_EX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParent_Click(object sender, EventArgs e)
        {
            SIS mySIS = new SIS();
            int totals = mySIS.getTotals();
            mySIS.Amount = -10;
            int amount = mySIS.Amount;
            MessageBox.Show("商品總計:" + totals.ToString() + "元\n金額:" + amount.ToString(),"SIS物件");
        }

        private void btnChild_Click(object sender, EventArgs e)
        {
            Stock myStock = new Stock();
            int totals = myStock.getTotals();
            myStock.Amount = -10;
            int amount = myStock.Amount;
            MessageBox.Show("商品總計:" + totals.ToString() + "元\n金額:" + amount.ToString(), "Stock物件");
        }
    }
}
