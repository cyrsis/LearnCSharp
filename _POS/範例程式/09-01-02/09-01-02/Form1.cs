using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_01_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new XINEntities())
            {
                var Customer = context.Customer;
                foreach (var recs in Customer)
                {
                    listBox1.Items.Add(recs.CustomerID + "," + recs.CompanyName);
                }
            }
        }
    }
}
