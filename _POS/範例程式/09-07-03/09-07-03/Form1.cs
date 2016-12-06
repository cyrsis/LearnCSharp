using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_07_03
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
            XINEntities context = new XINEntities();
            //建立查詢語言
            var prodCountQuery =
                from details in context.DeliveryDetails
                group details by new { details.ProductID, 
                                       details.Product.ProductName } 
                                       into grouping
                where grouping.Count() >= 10
                select new
                {
                   商品編號 = grouping.Key.ProductID,
                   商品名稱 = grouping.Key.ProductName,
                   總出貨明細筆數  = grouping.Count()
                };
            dataGridView1.DataSource = prodCountQuery;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 400;
            dataGridView1.Columns[2].Width = 150;
        }
    }
}
