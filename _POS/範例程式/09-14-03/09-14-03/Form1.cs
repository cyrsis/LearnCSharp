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

namespace _09_14_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //建立連接字串
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
            sqlBuilder.DataSource = "localhost";
            sqlBuilder.InitialCatalog = "XIN";
            sqlBuilder.IntegratedSecurity = true;
            //建立連接物件
            SqlConnection cnSQL = new SqlConnection(sqlBuilder.ToString());
            SqlDataReader rdrSQL;
            //開啟連接
            cnSQL.Open();
            //定義命令物件
            SqlCommand cmdSQL  = cnSQL.CreateCommand();
            //查詢所有倉庫代碼的SQL指令
            cmdSQL.CommandText = "SELECT * FROM Programs";
            //執行SQL命令
            rdrSQL = cmdSQL.ExecuteReader();
            using (var context = new XINEntities())
            {
                //將查詢的結果放入Programs資料表實體
                foreach (Programs P in context.Translate<Programs>(rdrSQL))
                {
                    listBox1.Items.Add(P.ProgramID + "," + P.ProgramName);
                }
            }
            rdrSQL.Close();
            //關閉連接物件
            cnSQL.Close();
        }
    }
}
