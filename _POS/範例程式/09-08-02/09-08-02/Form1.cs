using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_08_02
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
                          join D in context.DeliveryDetails
                          on M.DeliveryID equals D.DeliveryID
                          into Docs
                          where M.DeliveryType == "1"
                          orderby M.DeliveryID
                          let Qty = Docs.Sum(S => S.Quantity)
                          select new
                          {
                                出貨單號 = M.DeliveryID,
                                出貨日期 = M.DeliveryDate,
                                客戶簡稱 = M.Customer.AttribName,
                                總計金額 = M.Amount,
                                總計數量 = Qty
                          };
                dataGridView1.DataSource = qry;
            }        
        }
    }
}
