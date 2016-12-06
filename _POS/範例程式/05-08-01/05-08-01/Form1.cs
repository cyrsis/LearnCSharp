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

namespace _05_08_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            //連線字串
            String strConnectionString = "Data Source=localhost;" +
                                         "Integrated Security=True;" +
                                         "Initial Catalog=XIN;" +
                                         "Asynchronous Processing=True";
            //比對字串是否有SELECT
            if (txtSQL.Text.StartsWith("SELECT", 
                            StringComparison.CurrentCultureIgnoreCase))
            {
                RunExecuteReader(txtSQL.Text, strConnectionString);
            }
            else
            {
                RunExecuteNonQuery(txtSQL.Text, strConnectionString);
            }
        }

        private void RunExecuteReader(String strCommandText, 
                                      String strConnectionString)
        {
            using (SqlConnection cn = new SqlConnection(strConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(strCommandText, cn);

                    cn.Open();
                    //開啟非同步查詢
                    IAsyncResult result = cmd.BeginExecuteReader();
                    //等待查詢結束
                    while (!result.IsCompleted)
                    {
                        System.Threading.Thread.Sleep(100);
                    }
                    //結束非同步查詢,取得結果
                    using (SqlDataReader reader = cmd.EndExecuteReader(result))
                    {
                        DisplayResults(reader);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "錯誤", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DisplayResults(SqlDataReader reader)
        {
            //逐筆顯示結果
            while (reader.Read())
            {
                String strField;
                String strResult = "";
                for (int i = 0; i <= reader.FieldCount - 1; i++)
                {
                    strField = Convert.ToString(reader.GetValue(i));
                    strResult = strResult + strField + "\t";
                }
                listBox1.Items.Add(strResult);
            }
        }

        private void RunExecuteNonQuery(String strCommandText, 
                                        String strConnectionString)
        {
            using (SqlConnection cn = new SqlConnection(strConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(strCommandText, cn);
                    cn.Open();
                    //開啟非同步查詢
                    IAsyncResult result = cmd.BeginExecuteNonQuery();
                    //等待查詢結束
                    while (!result.IsCompleted)
                    {
                        System.Threading.Thread.Sleep(100);
                    }
                    //結束非同步查詢,取得結果
                    Int32 iAffected;
                    iAffected = cmd.EndExecuteNonQuery(result);
                    listBox1.Items.Add("共影響筆數:" + iAffected.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "錯誤",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
