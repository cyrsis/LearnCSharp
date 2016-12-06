using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects;

namespace _09_01_04
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
                ObjectQuery<Customer> query = context.Customer;
                foreach (Customer recs in query)
                {
                    listBox1.Items.Add(recs.CustomerID + "," + recs.CompanyName);
                }
            }
        }
    }
}
