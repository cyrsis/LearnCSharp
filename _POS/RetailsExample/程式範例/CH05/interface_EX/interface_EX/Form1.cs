using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface_EX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStockNew_Click(object sender, EventArgs e)
        {
            iToolStrip stock = new Stock();
            string result = stock.Insert();
            MessageBox.Show(result, "Stock類別");
        }

        private void btnShipNew_Click(object sender, EventArgs e)
        {
            iToolStrip ship = new Ship();
            string result = ship.Insert();
            MessageBox.Show(result, "Ship類別");
        }
    }
}
