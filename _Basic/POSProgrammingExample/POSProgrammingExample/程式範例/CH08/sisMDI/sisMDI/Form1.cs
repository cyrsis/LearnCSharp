using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsbStock_Click(object sender, EventArgs e)
        {
            FrmStock stock = new FrmStock();
            stock.MdiParent =this;
            stock.Show();
        }

        private void tsbShip_Click(object sender, EventArgs e)
        {
            FrmShip ship = new FrmShip();
            ship.MdiParent = this;
            ship.Show();
        }

        private void tsbRMA_Click(object sender, EventArgs e)
        {
            FrmRMA rma = new FrmRMA();
            rma.MdiParent = this;
            rma.Show();
        }
    }
}
