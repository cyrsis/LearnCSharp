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
using System.Data.Common;

namespace _09_02_06
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
                ObjectQuery<DbDataRecord> query = context.Product.Select(
                             "it.ProductID, it.ProductName");
                foreach (DbDataRecord recs in query)
                {
                    listBox1.Items.Add(recs["ProductID"] + "," + recs["ProductName"]);
                }
            }
        }
    }
}
