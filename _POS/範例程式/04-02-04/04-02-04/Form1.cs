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

namespace _04_02_04
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
            using (SqlConnection cnXIN = new SqlConnection())
            {
                //填入連線字串--請依自己的環境調整參數值
                cnXIN.ConnectionString =
                        "Data Source=localhost;" +
                        "Initial Catalog=XIN;" +
                        "User ID=sa;Password=sa;";
                //開啟連接物件
                cnXIN.Open();
                //
                //
                //Do Something...
                //
                //
            }
            //自動關閉連接物件與釋放所佔用的資源
        }
    }
}
