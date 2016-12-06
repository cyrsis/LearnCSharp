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

namespace _08_01_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //定義查詢的SQL指令
            cmdSQL.CommandText = "SELECT ProductID, ProductName, Unit, Price " +
                                 "FROM Product";
            //定義SqlDaatReader物件
            SqlDataReader rdProduct;
            //開啟SqlConnection物件
            cnSQL.Open();
            //執行ExecuteReader方法
            rdProduct = cmdSQL.ExecuteReader(CommandBehavior.CloseConnection);
            listBox1.Items.Clear();
            //取得每一筆客戶記錄的資料
            while (rdProduct.Read())
            {
                listBox1.Items.Add(rdProduct[0] + "," +
                                   rdProduct[1] + "," +
                                   rdProduct[2] + "," +
                                   rdProduct[3]);
            }
            //關閉SqlDataReader物件(會同時關閉SqlConnection物件)
            rdProduct.Close();
        }
    }
}
