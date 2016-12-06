using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_05_04
{
    public partial class Form1 : Form
    {

        DataTable dtProduct;
        DataView dvProduct;     
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateProductTable();
            dvProduct = dtProduct.DefaultView;
            DataGridView1.DataSource = dvProduct;
        }

        private void CreateProductTable()
        {
            dtProduct = new DataTable("Product");
            //商品編號
            DataColumn colProductID = new DataColumn("ProductID");
            colProductID.DataType = System.Type.GetType("System.String");
            colProductID.MaxLength = 10;
            colProductID.AllowDBNull = false;
            //商品名稱
            DataColumn colProductName = new DataColumn("ProductName");
            colProductName.DataType = System.Type.GetType("System.String");
            colProductName.MaxLength = 30;
            colProductName.AllowDBNull = false;
            colProductName.Unique = true;
            //建議售價
            DataColumn colPrice = new DataColumn("Price");
            colPrice.DataType = System.Type.GetType("System.Int32");
            colPrice.DefaultValue = 0;
            //銷量
            DataColumn colQuantity = new DataColumn("Quantity");
            colQuantity.DataType = System.Type.GetType("System.Int32");
            colQuantity.DefaultValue = 0;
            //將欄位加入資料表
            dtProduct.Columns.Add(colProductID);
            dtProduct.Columns.Add(colProductName);
            dtProduct.Columns.Add(colPrice);
            dtProduct.Columns.Add(colQuantity);
            //建立商品資料表的主索引鍵
            dtProduct.Rows.Add(new Object[] { "P2297", "Visual Basic.Net進銷存程式設計", 580, 13398 });
            dtProduct.Rows.Add(new Object[] { "P7117", "Visual Basic 2005資料庫程式設計", 650, 1528 });
            dtProduct.Rows.Add(new Object[] { "D8016", "Access 2007進銷存管理系統實作", 580, 29856 });
            dtProduct.Rows.Add(new Object[] { "P8177", "ADO.NET 3.X資料庫程式設計參考手冊-適用VB.C#", 680, 16879 });
            dtProduct.Rows.Add(new Object[] { "P8287", "Visual Basic 2008網路程式設計", 520, 9238 });
            dtProduct.Rows.Add(new Object[] { "D09016", "SQL Server 2008設計與應用實務", 580, 6533 });
            //加入主索引鍵
            dtProduct.PrimaryKey = new DataColumn[] { dtProduct.Columns["ProductID"] };
            //
            ComboBox1.Items.Add("ProductID");
            ComboBox1.Items.Add("ProductName");
            DataGridView1.DataSource = dvProduct;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //套用排序
            dvProduct.Sort = ComboBox1.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //移除排序
            dvProduct.Sort = "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int rowIndex = dvProduct.Find(txtFind.Text);
            if (rowIndex == -1)
            {
                MessageBox.Show("沒找到欄位:" + ComboBox1.Text + 
                                "為" + txtFind.Text + "的值!");
            }
            else
            {
                MessageBox.Show("找到欄位:" + ComboBox1.Text + 
                                "為" + txtFind.Text + "的值,在第" + 
                                Convert.ToString(rowIndex) + "筆記錄!");
            }
        }
    }
}
