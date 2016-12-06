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

namespace _09_05_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sSQL = @"SELECT Delivery.CustomerID
                            FROM XINEntities.Delivery AS Delivery
                            GROUP BY Delivery.CustomerID   
                            ORDER BY Delivery.CustomerID";
            using (var context =  new XINEntities())
            {
                foreach (DbDataRecord recs in
                    new ObjectQuery<DbDataRecord>(sSQL, context))
                {
                    listBox1.Items.Add(recs[0]);
                }
            }
        }
    }
}
