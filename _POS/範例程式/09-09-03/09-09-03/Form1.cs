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

namespace _09_09_03
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
                ObjectQuery<DbDataRecord> query = context.Customer
                           .Select("it.CustomerID, it.CompanyName, it.Delivery")
                           .Where("it.CustomerID = @CustomerID", 
                           new ObjectParameter("CustomerID", textBox1.Text));
                listBox1.Items.Clear();
                foreach (DbDataRecord recs in query)
                {
                    listBox1.Items.Add(string.Format("客戶編號：{0}, 客戶名稱：{1}",
                                                     recs[0], recs[1]));
                    List<Delivery> list = (List<Delivery>)(recs[2]);
                    foreach (Delivery docs in list)
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
