using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_08_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //建立DataContext類別的物件
            XINEntities XIN = new XINEntities();
            var qry = from M in XIN.Delivery
                      from P in XIN.Product
                      join D in XIN.DeliveryDetails on
                        new { M.DeliveryID, P.ProductID } equals
                        new { D.DeliveryID, D.ProductID } into details
                        from dtls in details
                        select new
                        {
                            出貨單號 = M.DeliveryID,
                            商品編號 = P.ProductID,
                            商品名稱 = P.ProductName,
                            數量 = dtls.UnitPrice,
                            單價 = dtls.Quantity,
                            金額 = dtls.Amount
                        };
            //將DataGridView控制項加入資料繫結
            dataGridView1.DataSource = qry;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 450;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[5].Width = 80;
        }
    }
}
