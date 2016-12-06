using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_03_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Today.AddYears(-1);
            using (var context = new XINEntities())
            {
                var Product = from Item in context.Product
                              where (Item.LastReceiptDate >= dt
                              ||  Item.LastDeliveryDate >= dt)
                              && Item.StopSales == false
                              select new
                              {
                                  商品編號 = Item.ProductID,
                                  商品名稱 = Item.ProductName,
                                  最近進貨日 = Item.LastReceiptDate,
                                  最近出貨日 = Item.LastDeliveryDate
                              };
                dataGridView1.DataSource = Product;
            }
        }
    }
}
