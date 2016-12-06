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

namespace _06_01_01
{
    public partial class Form1 : Form
    {

        //定義Connection物件
        SqlConnection cn = new SqlConnection();
        //定義DataSet物件
        DataSet dsXIN;
        //定義DataTable物件
        DataTable dt = new DataTable("Product");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "Data Source=localhost;" +
                                  "Initial Catalog=XIN;" +
                                  "Integrated Security=SSPI;";
            //建立DataSet物件
            dsXIN = new DataSet("XIN");
            //把DataTable物件加入DataSet物件中
            dsXIN.Tables.Add(dt);
            //定義商品資料表的所有欄位物件  
            dt.Columns.Add("ProductID", System.Type.GetType("System.String"));
            dt.Columns.Add("ProductName", System.Type.GetType("System.String"));
            dt.Columns.Add("Unit", System.Type.GetType("System.String"));
            dt.Columns.Add("Price", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Stock", System.Type.GetType("System.Int32"));
            //商品編號
            dt.Columns["ProductID"].MaxLength = 10;
            dt.Columns["ProductID"].AllowDBNull = false;
            //商品名稱
            dt.Columns["ProductName"].MaxLength = 50;
            dt.Columns["ProductName"].AllowDBNull = false;
            //單位
            dt.Columns["Unit"].MaxLength = 4;
            dt.Columns["Unit"].AllowDBNull = false;
            //建議售價
            dt.Columns["Price"].DefaultValue = 0;
            dt.Columns["Price"].AllowDBNull = false;
            //庫存量
            dt.Columns["Stock"].DefaultValue = 0;
            dt.Columns["Stock"].AllowDBNull = false;
            //建立產品編號為Primary Key    
            Constraint pk = dt.Constraints.Add("ID", dt.Columns["ProductID"], true);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["ProductID"].HeaderText = "商品編號";
            dataGridView1.Columns["ProductName"].HeaderText = "商品名稱";
            dataGridView1.Columns["Unit"].HeaderText = "單位";
            dataGridView1.Columns["Price"].HeaderText = "建議售價";
            dataGridView1.Columns["Stock"].HeaderText = "庫存量";
            dataGridView1.Columns["ProductID"].Width = 95;
            dataGridView1.Columns["ProductName"].Width = 300;
            dataGridView1.Columns["Unit"].Width = 70;
            dataGridView1.Columns["Price"].Width = 95;
            dataGridView1.Columns["Stock"].Width = 90;
            dataGridView1.Columns["Stock"].ReadOnly = true;
        }

        //更新記錄
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //定義SqlCommand物件
            SqlCommand cmdSQL = new SqlCommand();
            //把SqlCommand物件的Connection屬性指向我們所建立的SqlConnection物件
            cmdSQL.Connection = cn;
            int iInsert, iUpdate, iDelete;
            //建立動態參數
            SqlParameter ProductID = new SqlParameter();
            SqlParameter ProductName = new SqlParameter();
            SqlParameter Unit = new SqlParameter();
            SqlParameter Price = new SqlParameter();
            //設定動態參數的名稱,資料型態,方向,大小
            ProductID.ParameterName = "@ProductID";
            ProductID.SqlDbType = SqlDbType.VarChar;
            ProductID.Direction = ParameterDirection.Input;
            ProductID.Size = 10;
            ProductName.ParameterName = "@ProductName";
            ProductName.SqlDbType = SqlDbType.VarChar;
            ProductName.Direction = ParameterDirection.Input;
            ProductName.Size = 50;
            Unit.ParameterName = "@Unit";
            Unit.SqlDbType = SqlDbType.VarChar;
            Unit.Direction = ParameterDirection.Input;
            Unit.Size = 4;
            Price.ParameterName = "@Price";
            Price.SqlDbType = SqlDbType.Int;
            Price.Direction = ParameterDirection.Input;
            //將動態參數加入SqlCommand
            cmdSQL.Parameters.Add(ProductID);
            cmdSQL.Parameters.Add(ProductName);
            cmdSQL.Parameters.Add(Unit);
            cmdSQL.Parameters.Add(Price);
            //建立dvProduct_INSERT, 用來篩選新增的資料
            DataView dvINSERT = new DataView(dt);
            dvINSERT.RowStateFilter = DataViewRowState.Added;
            //建立dvProduct_UPDATE, 用來篩選修改的資料
            DataView dvUPDATE = new DataView(dt);
            dvUPDATE.RowStateFilter = DataViewRowState.ModifiedCurrent;
            //建立dvProduct_DELETE, 用來篩選刪除的資料
            DataView dvDELETE = new DataView(dt);
            dvDELETE.RowStateFilter = DataViewRowState.Deleted;
            iInsert = 0;
            iUpdate = 0;
            iDelete = 0;
            try
            {
                //開啟和資料庫的連接
                cn.Open();
                //把修改的資料更新到資料庫
                foreach (DataRowView drv in dvUPDATE)
                {
                    //指定修改資料的SQL Command之內容
                    cmdSQL.CommandText = "UPDATE Product SET " +
                                         "ProductName = @ProductName, " +
                                         "Unit = @Unit, Price = @Price " +
                                         "WHERE ProductID = @ProductID ";
                    //指定動態參數的值
                    ProductID.Value = drv.Row["ProductID", DataRowVersion.Original];
                    ProductName.Value = drv.Row["ProductName"];
                    Unit.Value = drv.Row["Unit"];
                    Price.Value = drv.Row["Price"];
                    //執行刪除資料SqlCommand
                    iUpdate = iUpdate + cmdSQL.ExecuteNonQuery();
                }
                //把刪除的資料更新到資料庫
                foreach (DataRowView drv in dvDELETE)
                {
                    //指定刪除資料的SQLCommand之內容
                    cmdSQL.CommandText = "DELETE FROM Product " +
                                         "WHERE ProductID = @ProductID " +
                                         "AND ProductName = @ProductName " +
                                         "AND Unit = @Unit AND Price = @Price ";
                    //指定動態參數的值
                    ProductID.Value = drv.Row["ProductID", DataRowVersion.Original];
                    ProductName.Value = drv.Row["ProductName", DataRowVersion.Original];
                    Unit.Value = drv.Row["Unit", DataRowVersion.Original];
                    Price.Value = drv.Row["Price", DataRowVersion.Original];
                    //執行修改資料的SqlCommand
                    iDelete = iDelete + cmdSQL.ExecuteNonQuery();
                }
                //把新增的資料更新到資料庫
                foreach (DataRowView drvProduct in dvINSERT)
                {
                    //指定新增資料的SQL Command之內容
                    cmdSQL.CommandText = "INSERT INTO Product " +
                        " (ProductID, ProductName, Unit, Price, Stock) " +
                        "VALUES " +
                        " (@ProductID, @ProductName, @Unit, @Price, 0) ";
                    //指定動態參數的值
                    ProductID.Value = drvProduct.Row["ProductID"];
                    ProductName.Value = drvProduct.Row["ProductName"];
                    Unit.Value = drvProduct.Row["Unit"];
                    Price.Value = drvProduct.Row["Price"];
                    //執行新增資料的SqlCommand
                    iInsert = iInsert + cmdSQL.ExecuteNonQuery();
                }
                //更新DataTable
                dt.AcceptChanges();
                //顯示更新資料庫程序成功的提示
                MessageBox.Show("商品資料表更新成功!\r\n\r\n" +
                                "新增: " + Convert.ToString(iInsert) + " 筆.\r\n" +
                                "修改: " + Convert.ToString(iUpdate) + " 筆.\r\n" +
                                "刪除: " + Convert.ToString(iDelete) + " 筆.\r\n", 
                                "更新成功",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception Err)
            {
                //顯示錯誤訊息
                MessageBox.Show(Err.ToString());
                //取消更新
                dt.RejectChanges();
            }
            finally
            {
                //無論如何, 關閉資料庫
                cn.Close();
            }
        }

        //重讀記錄
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //建立DataRow
            DataRow drProduct;
            //建立DataReader物件
            SqlDataReader rdrProduct;
            //指定要讀取Product的SQL指令
            //定義SqlCommand物件
            SqlCommand cmdSQL = new SqlCommand("SELECT ProductID, ProductName, " +
                                               "Unit, Price, Stock " + 
                                               "FROM Product", cn);
            //開啟資料庫的連接
            cn.Open();
            //把讀取的Product丟給DataReader物件
            rdrProduct = cmdSQL.ExecuteReader(CommandBehavior.CloseConnection);
            //先清除dtProduct的內容
            dt.Clear();
            //把DataReader裡的每一筆資料加入dtProduct中
            while (rdrProduct.Read())
            {
                drProduct = dt.NewRow();
                drProduct["ProductID"] = rdrProduct.GetString(0);
                drProduct["ProductName"] = rdrProduct.GetString(1);
                drProduct["Unit"] = rdrProduct.GetString(2);
                drProduct["Price"] = rdrProduct.GetInt32(3);
                drProduct["Stock"] = rdrProduct.GetInt32(4);
                dt.Rows.Add(drProduct);
            }
            //關閉DataReader, 也會順便關閉cnSQL
            rdrProduct.Close();
            //加進來的資料都是Added狀態, 把它改為unchanged
            dt.AcceptChanges();
        }
    }
}
