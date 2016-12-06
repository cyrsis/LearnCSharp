using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_08_05
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
                var qry = (from prod in context.Product
                           from item in prod.DeliveryDetails
                           where item.Quantity > 0 && item.UnitPrice > 0
                           && prod.StopSales == false
                           orderby prod.ProductID
                           select new
                           {
                               商品編號 = prod.ProductID,
                               商品名稱 = prod.ProductName
                           }).Distinct() ;
                dataGridView1.DataSource = qry;
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].Width = 450;
            }    
        }
    }
}
