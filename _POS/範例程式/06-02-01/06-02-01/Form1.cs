using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_02_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //設定DataGridView控制項的資料繫結
            dataGridView1.DataSource = dsXIN1;
            dataGridView1.DataMember = "Product";
            dataGridView1.Columns["ProductID"].HeaderText = "商品編號";
            dataGridView1.Columns["ProductName"].HeaderText = "商品名稱";
            dataGridView1.Columns["Unit"].HeaderText = "單位";
            dataGridView1.Columns["Price"].HeaderText = "建議售價";
            dataGridView1.Columns["Stock"].HeaderText = "庫存量";
            dataGridView1.Columns["ProductID"].Width = 95;
            dataGridView1.Columns["ProductName"].Width = 300;
            dataGridView1.Columns["Unit"].Width = 70;
            dataGridView1.Columns["Price"].Width = 95;
            dataGridView1.Columns["Stock"].Width = 90;
            dataGridView1.Columns["Stock"].ReadOnly = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //將資料集異動的記錄更新至資料庫
            sqlDataAdapter1.Update(dsXIN1);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //將資料填入資料集
            sqlDataAdapter1.Fill(dsXIN1);
        }
    }
}
