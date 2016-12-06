using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_04_04
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
                var Product = from Item in context.Product
                              where Item.StopSales == false
                              orderby Item.Price descending,
                                      Item.ProductID
                              select new
                              {
                                  商品編號 = Item.ProductID,
                                  商品名稱 = Item.ProductName,
                                  建議售價 = Item.Price
                              };
                dataGridView1.DataSource = Product;
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].Width = 500;
                dataGridView1.Columns[2].Width = 100;
            }
        }
    }
}
