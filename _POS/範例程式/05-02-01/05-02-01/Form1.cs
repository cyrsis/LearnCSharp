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

namespace _05_02_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //建立SqlCommand物件
            SqlCommand cmdSQL = new SqlCommand();
            //建立修改商品記錄的SQL敘述
            cmdSQL.CommandText = "UPDATE Product SET " +
                        "ProductName = @ProductName, " +
                        "Unit = @Unit, Price = @Price, " +
                        "Comment = @Comment " +
                        "WHERE ProductID = @ProductID ";
            //使用Add方法加入參數,並設定它的資料型態
            cmdSQL.Parameters.Add("@ProductID", SqlDbType.Char);
            //指定動態參數的值
            cmdSQL.Parameters["@ProductID"].Value = Convert.ToString(txtProductID.Text);
            //使用AddWithValue方法加入參數,並將值指向動態參數
            cmdSQL.Parameters.AddWithValue("@ProductName", txtProductName.Text);
            cmdSQL.Parameters.AddWithValue("@Unit", txtUnit.Text);
            cmdSQL.Parameters.AddWithValue("@Price", txtPrice.Text);
            cmdSQL.Parameters.AddWithValue("@Comment", txtComment.Text);

            //定義與建立連線物件
            using (SqlConnection cnSQL = new SqlConnection())
            {
                //填入連線字串
                cnSQL.ConnectionString =
                        "Data Source=localhost;" +
                        "Initial Catalog=XIN;" +
                        "Integrated Security=True;";
                //設定SqlCommand物件的SqlConnection物件
                cmdSQL.Connection = cnSQL;
                //開啟連接物件
                cnSQL.Open();
                //
                try
                {
                    int iCount;
                    //執行SQL指令
                    iCount = cmdSQL.ExecuteNonQuery();
                    MessageBox.Show("修改記錄成功!\r\n\r\n共" + iCount.ToString() + 
                                    "筆記錄");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
