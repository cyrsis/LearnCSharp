using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonPattern_ex
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
            stock.MdiParent = this;
            stock.Show();
        }

        private void tsbRMA_Click(object sender, EventArgs e)
        {
            FrmRMA.Instance.MdiParent = this;
            FrmRMA.Instance.Show();
        }
    }
}
