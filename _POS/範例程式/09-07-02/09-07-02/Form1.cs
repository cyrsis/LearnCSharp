using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_07_02
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
                var qry = from D in context.DeliveryDetails
                          group D by D.ProductID into prod
                          select new
                          {
                              商品編號 = prod.Key,
                              單筆最大金額 = prod.Max(D => D.Amount),
                              單筆最低金額 = prod.Min(D => D.Amount),
                              總計金額 = prod.Sum(D => D.Amount),
                              總出貨明細筆數 = prod.Count()
                          };          
                dataGridView1.DataSource = qry;
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].Width = 130;
                dataGridView1.Columns[2].Width = 130;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].Width = 150;
            }
        }
    }
}
