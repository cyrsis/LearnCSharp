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

namespace _09_04_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sSQL = @"SELECT P.ProductID, P.ProductName, P.Price 
                            FROM XINEntities.Product AS P
                            WHERE P.StopSales = false 
                            ORDER BY P.Price DESC, P.ProductName";
            using (var context =  new XINEntities())
            {
                var query = new ObjectQuery<DbDataRecord>(sSQL, context);
                dataGridView1.DataSource = query;
                dataGridView1.Columns[0].HeaderText = "商品編號";
                dataGridView1.Columns[1].HeaderText = "商品名稱";
                dataGridView1.Columns[2].HeaderText = "建議售價";
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].Width = 500;
                dataGridView1.Columns[2].Width = 100;
            }
        }
    }
}
