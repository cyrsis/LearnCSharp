using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_03_02
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
                              where Item.Price >= 500 && Item.Price <= 600
                              select new {
                                  商品編號 = Item.ProductID,
                                  商品名稱 = Item.ProductName,
                                  建議售價 = Item.Price
                              };
                dataGridView1.DataSource = Product;
            }
        }
    }
}
