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

namespace _05_05_01
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
            sqlCommand1.Parameters["@ProductID"].Value = txtProductID.Text;
            //開啟連接
            sqlConnection1.Open();
            //建立SqlDataReader物件
            SqlDataReader dr;
            //因為傳回是一個結果集, 故用ExecuteReader
            dr = sqlCommand1.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.Read())
            {
                Int32 idxCol;
                //由欄位名稱取的索引
                idxCol = dr.GetOrdinal("ProductName");
                txtProductName.Text = dr.GetString(idxCol);
                listBox1.Items.Add("  出貨單#    售價     數量     出貨金額  ");
                listBox1.Items.Add("----------+--------+--------+------------");
                while (dr.Read())
                {
                    String sRecs;
                    //出貨單號碼
                    idxCol = dr.GetOrdinal("DeliveryID");
                    sRecs = dr.GetString(idxCol) + "\t";
                    //售價
                    idxCol = dr.GetOrdinal("UnitPrice");
                    sRecs = sRecs + dr.GetInt32(idxCol).ToString("#,##0") + "\t";
                    //出貨數量
                    idxCol = dr.GetOrdinal("Quantity");
                    sRecs = sRecs + dr.GetInt32(idxCol).ToString("#,##0") + "\t";
                    //出貨金額
                    idxCol = dr.GetOrdinal("Amount");
                    sRecs = sRecs + dr.GetInt32(idxCol).ToString("#,##0");
                    listBox1.Items.Add(sRecs);
                }
            }
            else
            {
                MessageBox.Show("找不到出貨記錄!", "預存程序", 
                                MessageBoxButtons.OK);
            }
            //關閉SqlDataReader物件
            dr.Close();
        }


    }
}
