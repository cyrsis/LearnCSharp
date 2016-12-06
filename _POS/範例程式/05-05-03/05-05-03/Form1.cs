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

namespace _05_05_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //將所需的條件帶入
            sqlCommand1.Parameters["@BeginDate"].Value = dateTimePicker1.Value;
            sqlCommand1.Parameters["@EndDate"].Value = dateTimePicker2.Value;
            //開啟連接
            sqlConnection1.Open();
            //建立SqlDataReader物件
            SqlDataReader dr;
            //因為傳回是一個結果集, 故用ExecuteReader
            dr = sqlCommand1.ExecuteReader(CommandBehavior.CloseConnection);
            String sRecs;
            int iResult;
            iResult = 0;
            if (dr.HasRows)
            {
                do
                {
                    iResult += 1;
                    listBox1.Items.Add("第" + iResult.ToString() + "個結果集");
                    while (dr.Read())
                    {
                        sRecs = "";
                        for (int i = 0; i <= dr.FieldCount - 1; i++)
                        {
                            sRecs = sRecs + Convert.ToString(dr.GetValue(i)) + "\t";
                        }
                        listBox1.Items.Add(sRecs);
                    }
                    listBox1.Items.Add("");
                    listBox1.Items.Add("");
                    //取下一個結果集
                } while (dr.NextResult());
            }
            else
            {
                MessageBox.Show("找不到出貨記錄!", "預存程序", MessageBoxButtons.OK);
            }
            //關閉SqlDataReader物件
            dr.Close();
        }
    }
}
