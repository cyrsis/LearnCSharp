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

namespace _05_03_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //建立SqlConnection物件
            SqlConnection cnSQL = new SqlConnection();
            //定義連線字串
            cnSQL.ConnectionString = "Data Source=localhost;" +
                                     "Initial Catalog=XIN;" +
                                     "Integrated Security=True;";
            //定義查詢的SQL指令
            String strSQL;
            strSQL = "SELECT * FROM Product";
            //建立SqlCommand物件,並指定它的SQL命令與SqlConnection物件
            SqlCommand cmdSQL = new SqlCommand(strSQL, cnSQL);
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
                listBox1.Items.Add(rdProduct.GetString(0) + "  -  " + 
                                   rdProduct.GetString(1));
            }
            //關閉SqlDataReader物件(會同時關閉SqlConnection物件)
            rdProduct.Close();
        }
    }
}
