using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_02_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBeginLoadData_Click(object sender, EventArgs e)
        {
            //建立DataTable
            DataTable dtProduct = dsXIN1.Tables["Product"];
            //關閉條件約束
            dtProduct.BeginLoadData();
            //填入資料
            sqlDataAdapter1.Fill(dsXIN1, "Product");
            //開啟條件約束
            dtProduct.EndLoadData();
        }

        private void btnEnforceConstraints_Click(object sender, EventArgs e)
        {
            //關閉條件約束
            dsXIN1.EnforceConstraints = false;
            //填入資料
            sqlDataAdapter1.Fill(dsXIN1);
            //開啟條件約束
            dsXIN1.EnforceConstraints = true;
        }
    }
}
