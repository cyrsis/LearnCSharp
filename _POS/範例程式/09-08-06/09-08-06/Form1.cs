using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_08_06
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
                var qry = from cust in context.Customer 
                          join docs in context.Delivery 
                          on cust.CustomerID equals docs.CustomerID 
                          join item in context.DeliveryDetails 
                          on docs.DeliveryID equals item.DeliveryID
                          join prod in context.Product 
                          on item.ProductID equals prod.ProductID
                           orderby docs.CustomerID, docs.DeliveryID
                           select new
                           {
                               客戶編號 = cust.CustomerID,
                               客戶簡稱 = cust.AttribName,
                               出貨日期 = docs.DeliveryDate,
                               出貨單號 = docs.DeliveryID,
                               商品編號 = prod.ProductID,
                               商品名稱 = prod.ProductName,
                               數量 = item.Quantity,
                               單價 = item.UnitPrice,
                               金額 = item.Amount
                           };
                dataGridView1.DataSource = qry;
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[5].Width = 450;
                dataGridView1.Columns[6].Width = 70;
                dataGridView1.Columns[7].Width = 70;
                dataGridView1.Columns[8].Width = 80;
            }   
        }
    }
}
