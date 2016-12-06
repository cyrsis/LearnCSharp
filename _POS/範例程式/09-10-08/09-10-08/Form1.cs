﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.Objects;

namespace _09_10_08
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
                string sSQL = "(SELECT cust.CustomerID, cust.CompanyName " +
                              " FROM XINEntities.Customer AS cust) " +
                              "INTERSECT " +
                              "(SELECT docs.CustomerID, docs.Customer.CompanyName " +
                              " FROM XINEntities.Delivery AS docs) ";
                var query = new ObjectQuery<DbDataRecord>(sSQL, context);
                //將DataGridView控制項加入資料繫結
                dataGridView1.DataSource = query;
                //變更欄位顯示寬度
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].Width = 300;
                dataGridView1.Columns[0].HeaderText = "客戶編號";
                dataGridView1.Columns[1].HeaderText = "客戶名稱";
            }
        }
    }
}
