using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_08_03
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
                          from docs in cust.Delivery
                          orderby docs.DeliveryID
                          select new 
                          {
                              出貨單號 = docs.DeliveryID,
                              出貨日期 = docs.DeliveryDate,
                              客戶編號 = cust.CustomerID,
                              客戶簡稱 = cust.AttribName
                          };
                dataGridView1.DataSource = qry;
            }
        }
    }
}
