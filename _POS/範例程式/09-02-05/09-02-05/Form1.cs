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

namespace _09_02_05
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
                string sSQL = @"SELECT P.ProductID, P.ProductName 
                              FROM XINEntities.Product AS P";
                foreach (DbDataRecord recs 
                        in new ObjectQuery<DbDataRecord>(sSQL, context))
                {
                    listBox1.Items.Add(recs[0] + "," + recs[1]);
                }
            }
        }
    }
}
