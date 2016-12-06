using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _05_01_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //建立SqlConnectionStringBuilder物件
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";
            builder.InitialCatalog = "XIN";
            builder.IntegratedSecurity = true;
            //建立SqlConnection物件
            SqlConnection cnSQL = new SqlConnection();
            //將SqlConnectionStringBuilder的連線字串指向SqlConnection物件
            cnSQL.ConnectionString = builder.ConnectionString;
            //建立SqlCommand物件
            SqlCommand cmdSQL = new SqlCommand();
            //設定SqlCommand物件的SqlConnection物件
            cmdSQL.Connection = cnSQL;
            //建立新增商品記錄的SQL敘述
            cmdSQL.CommandText = "INSERT INTO Product " +
                " (ProductID, ProductName, Unit, StopSales, Price, Comment) " +
                "VALUES " +
                " ('" + txtProductID.Text + "', " +
                "'" + txtProductName.Text + "', " +
                "'" + txtUnit.Text + "', " +
                "0, " +
                txtPrice.Text + ", " +
                "'" + txtComment.Text + "') ";
            int iCount;
            try
            {
                //開啟SqlConnection物件
                cnSQL.Open();
                try
                {
                    //執行SQL指令
                    iCount = cmdSQL.ExecuteNonQuery();
                    MessageBox.Show("新增記錄成功!\r\n\r\n共" + iCount.ToString() +
                                    "筆記錄");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            finally
            {
                //關閉SqlConnection物件
                cnSQL.Close();
            }
        }
    }
}
