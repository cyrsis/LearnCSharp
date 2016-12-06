using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_05_01
{
    public partial class Form1 : Form
    {
       
        DataSet dsXIN;
        DataTable dtProduct;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsXIN = new DataSet("XIN");
            dtProduct = dsXIN.Tables.Add("Product");
            //商品編號
            DataColumn colProductID = new DataColumn("ProductID");
            colProductID.DataType = System.Type.GetType("System.String");
            colProductID.MaxLength = 10;
            colProductID.AllowDBNull = false;
            //商品名稱
            DataColumn colProductName = new DataColumn("ProductName");
            colProductName.DataType = System.Type.GetType("System.String");
            colProductName.MaxLength = 50;
            colProductName.AllowDBNull = false;
            //價格
            DataColumn colPrice = new DataColumn("Price");
            colPrice.DataType = System.Type.GetType("System.Int32");
            colPrice.DefaultValue = 0;
            colPrice.AllowDBNull = false;
            //庫存量
            DataColumn colQuantity = new DataColumn("Quantity");
            colQuantity.DataType = System.Type.GetType("System.Int32");
            colQuantity.DefaultValue = 0;
            colQuantity.AllowDBNull = false;
            //將欄位加入資料表
            dtProduct.Columns.Add(colProductID);
            dtProduct.Columns.Add(colProductName);
            dtProduct.Columns.Add(colPrice);
            dtProduct.Columns.Add(colQuantity);
            //設定DataGridView控制項顯示dsXIN資料集裡的Product資料表
            dataGridView1.DataSource = dsXIN;
            dataGridView1.DataMember = "Product";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //建立DataRow物件
            DataRow drNewProduct;
            //新增DataRow方式A
            //新增DataRow項目
            drNewProduct = dtProduct.NewRow();
            //在新DataRow給予值
            drNewProduct["ProductID"] = "P2297";
            drNewProduct["ProductName"] = "Visual Basic.Net進銷存程式設計";
            drNewProduct["Price"] = 580;
            drNewProduct["Quantity"] = 20;
            //將新增的DataRow項目加入資料表
            dtProduct.Rows.Add(drNewProduct);
            //新增DataRow方式B
            //新增DataRow項目
            drNewProduct = dtProduct.NewRow();
            //在新DataRow給予值
            drNewProduct[0] = "P7117";
            drNewProduct[1] = "Visual Basic 2005資料庫程式設計";
            drNewProduct[2] = 650;
            drNewProduct[3] = 30;
            //將新增的DataRow項目加入資料表
            dtProduct.Rows.Add(drNewProduct);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int I, intCount;
            intCount = dtProduct.Rows.Count - 1;
            for (I = intCount; I >= 0; I--)
            {
                DataRow rowDelete = dtProduct.Rows[I];
                dtProduct.Rows.Remove(rowDelete);
            }
        }
    }
}
