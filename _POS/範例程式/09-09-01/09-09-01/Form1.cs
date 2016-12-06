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

namespace _09_09_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new XINEntities())
            {
                ObjectSet<Customer> cust  = context.Customer;
                var qry = from R in cust
                          where R.CustomerID == textBox1.Text
                          select new
                          {
                              CustomerID = R.CustomerID,
                              CustomerName = R.CompanyName,
                              DeliveryData = R.Delivery
                          };
                listBox1.Items.Clear();
                foreach (var M in qry)
                {
                    listBox1.Items.Add(string.Format("客戶編號：{0}, 客戶名稱：{1}",
                               M.CustomerID, M.CustomerName));
                    foreach (var docs in M.DeliveryData)
                    {
                        listBox1.Items.Add(string.Format(
                             "出貨單號：{0}, 出貨日期：{1}, 出貨金額：{2}",
                             docs.DeliveryID, docs.DeliveryDate, docs.Amount));
                    }
                }
            }
        }
    }
}
