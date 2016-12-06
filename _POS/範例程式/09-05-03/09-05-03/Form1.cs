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

namespace _09_05_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context =  new XINEntities())
            {
                ObjectQuery<DbDataRecord> query =
                    context.Delivery
                    .GroupBy("it.CustomerID", "CustomerID")
                    .Select("it.CustomerID")
                    .OrderBy("it.CustomerID");
                foreach (DbDataRecord recs in query)
                {
                    listBox1.Items.Add(recs["CustomerID"]);
                }
            }
        }
    }
}
