using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_09_01
{
    public partial class Form1 : Form
    {

        DataTable dtBooks;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtBooks = new DataTable("Books");
            //建立欄位
            CreateDataColumn();
            //設定DataGridView控制項顯示dsKINGS資料集裡的Product資料表
            dataGridView1.DataSource = dtBooks;
            //設定TextBox控制項的資料繫結
            txtMaxQuantity.DataBindings.Add("Text", dtBooks, "MaxQuantity");
            txtMinQuantity.DataBindings.Add("Text", dtBooks, "MinQuantity");
            txtAvgQuantity.DataBindings.Add("Text", dtBooks, "AvgQuantity");
            txtTitleCount.DataBindings.Add("Text", dtBooks, "TitleCount");
            txtDescription.DataBindings.Add("Text", dtBooks, "Description");
            txtSubBookID.DataBindings.Add("Text", dtBooks, "SubBookID");
            txtAppraisal.DataBindings.Add("Text", dtBooks, "Appraisal");
            //新增DataRow項目
            dtBooks.Rows.Add(new Object[] { "P2297", "Visual Basic.Net進銷存程式設計", 580, 13398 });
            dtBooks.Rows.Add(new Object[] { "P7117", "Visual Basic 2005資料庫程式設計", 650, 1528 });
            dtBooks.Rows.Add(new Object[] { "D8016", "Access 2007進銷存管理系統實作", 580, 29856 });
            dtBooks.Rows.Add(new Object[] { "P8177", "ADO.NET 3.X資料庫程式設計參考手冊-適用VB.C#", 680, 16879 });
            dtBooks.Rows.Add(new Object[] { "P8287", "Visual Basic 2008網路程式設計", 520, 9238 });
            dtBooks.Rows.Add(new Object[] { "D09016", "SQL Server 2008設計與應用實務", 580, 6533 });
            //加入主索引鍵
            dtBooks.PrimaryKey = new DataColumn[] { dtBooks.Columns["ProductID"] };
        }

        private void CreateDataColumn()
        {
            //書號
            DataColumn colBookID = new DataColumn("BookID");
            colBookID.DataType = System.Type.GetType("System.String");
            colBookID.MaxLength = 10;
            colBookID.AllowDBNull = false;
            //書名
            DataColumn colTitle = new DataColumn("Title");
            colTitle.DataType = System.Type.GetType("System.String");
            colTitle.MaxLength = 30;
            colTitle.AllowDBNull = false;
            colTitle.Unique = true;
            //建議售價
            DataColumn colPrice = new DataColumn("Price");
            colPrice.DataType = System.Type.GetType("System.Int32");
            colPrice.DefaultValue = 0;
            //銷量
            DataColumn colQuantity = new DataColumn("Quantity");
            colQuantity.DataType = System.Type.GetType("System.Int32");
            colQuantity.DefaultValue = 0;
            //將欄位加入資料表
            dtBooks.Columns.Add(colBookID);
            dtBooks.Columns.Add(colTitle);
            dtBooks.Columns.Add(colPrice);
            dtBooks.Columns.Add(colQuantity);
            //銷售金額
            DataColumn colGrandTotal = new DataColumn("GrandTotal");
            colGrandTotal.DataType = System.Type.GetType("System.Int32");
            colGrandTotal.Expression = "Price * Quantity";
            //最大銷售量
            DataColumn colMaxQuantity = new DataColumn("MaxQuantity");
            colMaxQuantity.DataType = System.Type.GetType("System.Int32");
            colMaxQuantity.Expression = "Max(Quantity)";
            //最小銷售量
            DataColumn colMinQuantity = new DataColumn("MinQuantity");
            colMinQuantity.DataType = System.Type.GetType("System.Int32");
            colMinQuantity.Expression = "Min(Quantity)";
            //平均銷售量
            DataColumn colAvgQuantity = new DataColumn("AvgQuantity");
            colAvgQuantity.DataType = System.Type.GetType("System.Decimal");
            colAvgQuantity.Expression = "Avg(Quantity)";
            //商品總數
            DataColumn colTitleCount = new DataColumn("TitleCount");
            colTitleCount.DataType = System.Type.GetType("System.Int32");
            colTitleCount.Expression = "Count(Title)";
            //售價說明
            DataColumn colDescription = new DataColumn("Description");
            colDescription.DataType = System.Type.GetType("System.String");
            colDescription.Expression = "'書名：' + TRIM(Title) + '的售價是NT$' + Price";
            //找出商品編號的第2~5碼
            DataColumn colSubBookID = new DataColumn("SubBookID");
            colSubBookID.DataType = System.Type.GetType("System.String");
            colSubBookID.Expression = "SUBSTRING(BookID, 2, 4)";
            //銷售評價
            DataColumn colAppraisal = new DataColumn("Appraisal");
            colAppraisal.DataType = System.Type.GetType("System.String");
            colAppraisal.Expression = "IIF(Quantity > 2000,'不錯!', '要加油!')";
            //將計算欄位加入資料表
            dtBooks.Columns.Add(colGrandTotal);
            dtBooks.Columns.Add(colMaxQuantity);
            dtBooks.Columns.Add(colMinQuantity);
            dtBooks.Columns.Add(colAvgQuantity);
            dtBooks.Columns.Add(colTitleCount);
            dtBooks.Columns.Add(colDescription);
            dtBooks.Columns.Add(colSubBookID);
            dtBooks.Columns.Add(colAppraisal);
            //建立商品資料表的主索引鍵
            dtBooks.PrimaryKey = new DataColumn[] { colBookID };
        }
    }
}
