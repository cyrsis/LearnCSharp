using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_10_04
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
                var query = (from Item in context.Product
                             select new
                             {
                                 商品編號 = Item.ProductID,
                                 商品名稱 = Item.ProductName
                             }
                            ).Except
                            (from dtls in context.DeliveryDetails
                             select new
                             {
                                 商品編號 = dtls.ProductID,
                                 商品名稱 = dtls.Product.ProductName
                             }
                            );
                //將DataGridView控制項加入資料繫結
                dataGridView1.DataSource = query;
                //變更欄位顯示寬度
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].Width = 450;
            }
        }
    }
}
