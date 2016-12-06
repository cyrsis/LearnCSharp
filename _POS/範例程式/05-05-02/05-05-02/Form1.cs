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
using Microsoft.VisualBasic;

namespace _05_05_02
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
            //開啟連接;
            sqlConnection1.Open();
            //建立SqlDataReader物件
            SqlDataReader dr;
            //因為傳回是一個結果集, 故用ExecuteReader
            dr = sqlCommand1.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.Read())
            {
                listBox1.Items.Add("名次  出貨金額  客戶編號" +
                                   "公司名稱                               ");
                listBox1.Items.Add("----+----------+--------+" +
                                   "----------------------------------------");
                int intSEQ;
                intSEQ = 0;
                while (dr.Read())
                {
                    //累計名次
                    intSEQ += 1;
                    Object[] ResultValues = new Object[dr.FieldCount];
                    dr.GetSqlValues(ResultValues);
                    intSEQ.ToString().PadRight(4);
                    listBox1.Items.Add(intSEQ.ToString().PadRight(4) + " " +
                                       ResultValues[2].ToString().PadLeft(10) + " " +
                                       ResultValues[0].ToString().PadRight(8) + " " +
                                       ResultValues[1].ToString().PadRight(40) + " ");
                }
            }
            else
            {
                MessageBox.Show("找不到訂購記錄!", "預存程序", MessageBoxButtons.OK);
            }
            //關閉SqlDataReader物件
            dr.Close();
        }
    }
}
