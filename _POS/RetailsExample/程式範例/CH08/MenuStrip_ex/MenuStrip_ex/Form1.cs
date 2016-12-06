using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.MdiWindowListItem = tsmiWindows;
        }

        private void tsmiStock_Click(object sender, EventArgs e)
        {
            FrmStock stock = new FrmStock();
            stock.MdiParent = this;
            stock.Show();
        }

        private void tsmiShip_Click(object sender, EventArgs e)
        {
            FrmShip ship = new FrmShip();
            ship.MdiParent = this;
            ship.Show();
        }

        private void tsmiRMA_Click(object sender, EventArgs e)
        {
            FrmRMA rma = new FrmRMA();
            rma.MdiParent = this;
            rma.Show();
        }
    }
}
