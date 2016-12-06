using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_10_02
{
    public partial class Form1 : Form
    {

        DataTable dtProduct;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateProductTable();
            DataGridView1.DataSource = dtProduct;
        }

        private void CreateProductTable()
        {
            dtProduct = new DataTable("Product");
            //商品編號
            DataColumn colProductID = new DataColumn("ProductID");
            colProductID.DataType = System.Type.GetType("System.String");
            colProductID.MaxLength = 10;
            //商品名稱
            DataColumn colProductName = new DataColumn("ProductName");
            colProductName.DataType = System.Type.GetType("System.String");
            colProductName.MaxLength = 30;
            colProductName.AllowDBNull = false;

            //將欄位加入資料表
            dtProduct.Columns.Add(colProductID);
            dtProduct.Columns.Add(colProductName);

            //建立商品資料表的主索引鍵
            dtProduct.PrimaryKey = new DataColumn[] { colProductID };
            //新增商品記錄
            dtProduct.Rows.Add(new Object[] { "P2297", "Visual Basic.Net進銷存程式設計" });
            dtProduct.Rows.Add(new Object[] { "P7117", "Visual Basic 2005資料庫程式設計" });
            dtProduct.Rows.Add(new Object[] { "P9999", "Access 2007進銷存管理系統實作" });
            dtProduct.Rows.Add(new Object[] { "P3117", "ASP.NET會計系統程式設計" });
        }

        private void btnToCopy_Click(object sender, EventArgs e)
        {
            //定義DataView
            DataView dvProduct;
            //建立DataTable的DefaultView
            dvProduct = dtProduct.DefaultView;
            //設定DataView的RowFilter屬性
            dvProduct.RowFilter = txtRowFilter.Text;
            //定義DataTable
            DataTable dtToTable;
            //把篩選出來的DataView複製到目的資料表
            dtToTable = dvProduct.ToTable();
            //DataGridView2控制項顯示目的資料表的記錄
            DataGridView2.DataSource = dtToTable;
            //清除原來的DataView的RowFilter屬性
            dvProduct.RowFilter = "";
        }


    }
}
