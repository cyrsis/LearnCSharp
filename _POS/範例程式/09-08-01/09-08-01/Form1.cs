using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_08_01
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
                var qry = from M in context.Delivery
                          join D in context.DeliveryDetails on M.DeliveryID equals D.DeliveryID
                          orderby M.DeliveryID
                          select new
                          {
                             出貨單號 = M.DeliveryID,
                             出貨日期 = M.DeliveryDate,
                             客戶編號 =  M.CustomerID,
                             商品編號 =  D.ProductID,
                             數量 =  D.Quantity,
                             單價 =  D.UnitPrice,
                             金額 =  D.Amount
                          };
                dataGridView1.DataSource = qry;
            }
        }
    }
}
