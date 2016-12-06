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

namespace _04_02_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //定義與建立連線物件
            SqlConnection cnXIN = new SqlConnection();
            //填入連線字串--請依自己的環境調整參數值
            cnXIN.ConnectionString =
                    "Data Source=(local);" +
                    "Initial Catalog=XIN;" +
                    "User ID=sa;Password=sa;";
            //開啟連接物件
            cnXIN.Open();
            //
            //
            //Do Something...
            //
            //
            //關閉連接物件
            cnXIN.Close();
            //釋放連接物件所佔用的資源
            cnXIN.Dispose();
            //取消物件變數的內容
            cnXIN = null;
        }
    }
}
