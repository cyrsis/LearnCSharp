using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_06_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new XINEntities())
            {
                var qry = (from R in context.Customer
                           where R.CustomerID == textBox1.Text
                           select R).FirstOrDefault();
                if (qry == null)
                {
                    //找不到記錄
                    txtCompanyName.Text = "";
                    label3.Text = "";
                    dataGridView1.DataSource = null;
                }
                else
                {
                    //找到記錄，取得客戶名稱
                    txtCompanyName.Text = qry.CompanyName;
                    label3.Text = "共有" + qry.Delivery.Count.ToString() +
                                  "筆出貨單";
                    //載入出貨單單資料
                    var Deliverys = from M in qry.Delivery.CreateSourceQuery()
                                    select M;
                    //將DataGridView控制項加入資料繫結
                    dataGridView1.DataSource = Deliverys;
                }
            }
        }
    }
}
