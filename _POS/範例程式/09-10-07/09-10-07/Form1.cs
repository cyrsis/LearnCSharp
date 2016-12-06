using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_10_07
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
                var query = (from cust in context.Customer
                             select new
                             {
                                 客戶編號 = cust.CustomerID,
                                 客戶名稱 = cust.CompanyName
                             }
                            ).Intersect
                            (from docs in context.Delivery
                             select new
                             {
                                 客戶編號 = docs.CustomerID,
                                 客戶名稱 = docs.Customer.CompanyName
                             }
                            );
                //將DataGridView控制項加入資料繫結
                dataGridView1.DataSource = query;
                //變更欄位顯示寬度
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].Width = 300;
            }
        }
    }
}
