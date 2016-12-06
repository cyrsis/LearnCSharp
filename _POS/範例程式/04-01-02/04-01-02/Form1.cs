using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _04_01_02
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
            OleDbConnection cnXIN = new OleDbConnection();
            //填入連線字串--請依自己的環境調整參數值
            cnXIN.ConnectionString =
                "Provider=SQLOLEDB;" +
                "Data Source=BENNY-VAIO;" +
                "Initial Catalog=XIN;" +
                "User ID=sa;Password=sa;";
            //開啟連接物件
            cnXIN.Open();
        }
    }
}
