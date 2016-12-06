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

namespace _05_02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //定義與建立連線物件
            using (SqlConnection cnSQL = new SqlConnection())
            {
                //填入連線字串
                cnSQL.ConnectionString = "Data Source=localhost;" +
                                         "Initial Catalog=XIN;" +
                                         "Integrated Security=True;";
                //開啟連接物件
                cnSQL.Open();
                //使用SqlConnection物件來建立SqlCommand物件
                using (SqlCommand cmdSQL = cnSQL.CreateCommand())
                {
                    //建立修改商品記錄的SQL敘述
                    cmdSQL.CommandText = "DELETE FROM Product " + 
                                         "WHERE ProductID = @ProductID ";
                    //建立動態參數
                    SqlParameter ProductID = new SqlParameter();
                    //設定動態參數的名稱
                    ProductID.ParameterName = "@ProductID";
                    //設定動態參數的資料型態
                    ProductID.SqlDbType = SqlDbType.Char;
                    //設定動態參數的方向為輸入
                    ProductID.Direction = ParameterDirection.Input;
                    //設定動態參數的大小(就是資料所占的位元組數)
                    ProductID.Size = 10;
                    //設定動態參數的值
                    ProductID.Value = txtProductID.Text;
                    //將動態參數加入DbCommand的Parameters
                    cmdSQL.Parameters.Add(ProductID);
                    //
                    try
                    {
                        int iCount;
                        //執行SQL指令
                        iCount = cmdSQL.ExecuteNonQuery();
                        MessageBox.Show("刪除記錄成功!\r\n\r\n共" + 
                                        iCount.ToString() + "筆記錄");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
