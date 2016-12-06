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

namespace _04_07_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //定義與建立連線字串物件--請依自己的環境調整參數值
            SqlConnectionStringBuilder cnString = new SqlConnectionStringBuilder();
            cnString.DataSource = "BENNY-VAIO";
            cnString.InitialCatalog = "XIN";
            cnString.UserID = "sa";
            cnString.Password = "sa";
            //定義與建立連線物件
            SqlConnection cnXIN = new SqlConnection();
            //填入連線字串
            cnXIN.ConnectionString = cnString.ConnectionString;
            //開啟連接物件
            cnXIN.Open();
        }
    }
}
