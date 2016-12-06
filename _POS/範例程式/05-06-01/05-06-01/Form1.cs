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


namespace _05_06_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long lngTicks;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            int i;
            //連線字串
            cn.ConnectionString = "Data Source=localhost;" +
                                  "Initial Catalog=XIN;" +
                                  "Integrated Security=SSPI";
            cmd.Connection = cn;
            cmd.CommandText = "DELETE FROM Product " +
                              "WHERE ProductID >= '10001' " +
                              "AND ProductID <= '20000' ";
            //開啟連接物件
            cn.Open();
            //刪除測試用的商品記錄
            cmd.ExecuteNonQuery();
            //關閉連接物件
            cn.Close();
            //建立新增商品的SQL敘述
            cmd.CommandText = 
                "INSERT INTO Product " +
                " (ProductID, ProductName, Unit, StopSales, Price) " +
                "VALUES " +
                " (@ProductID, @ProductName, @Unit, @StopSales, @Price) ";
            //建立SqlParameter物件
            //商品編號
            SqlParameter sprProductID =
                new SqlParameter("@ProductID", SqlDbType.VarChar, 10);
            //商品名稱
            SqlParameter sprProductName = 
                new SqlParameter("@ProductName", SqlDbType.NVarChar, 50);
            //單位
            SqlParameter sprUnit = 
                new SqlParameter("@Unit", SqlDbType.NVarChar, 4);
            //停止銷售
            SqlParameter sprStopSales = 
                new SqlParameter("@StopSales", SqlDbType.Bit);
            //建議售價
            SqlParameter sprPrice = 
                new SqlParameter("@Price", SqlDbType.Int);
            //將SqlParameter物件加入SqlCommand物件的Parameter屬性
            cmd.Parameters.Add(sprProductID);
            cmd.Parameters.Add(sprProductName);
            cmd.Parameters.Add(sprUnit);
            cmd.Parameters.Add(sprStopSales);
            cmd.Parameters.Add(sprPrice);
            //開啟連接物件
            cn.Open();
            //是否預先編譯SQL指令
            if (cbPrepare.Checked)
            {
                cmd.Prepare();
            }
            //新增10000筆客戶記錄
            lngTicks = DateTime.Now.Ticks;
            for (i = 10001; i <= 20000; i++)
            {
                cmd.Parameters[0].Value = i.ToString();
                cmd.Parameters[1].Value = "商品名稱" + i.ToString();
                cmd.Parameters[2].Value = "本";
                cmd.Parameters[3].Value = 0;
                cmd.Parameters[4].Value = 500;
                cmd.ExecuteNonQuery();
            }
            cn.Close();
            //計算時間
            txtTime.Text = (Convert.ToDouble(DateTime.Now.Ticks - lngTicks) /
                             10000000).ToString("0.000");
        }
    }
}
