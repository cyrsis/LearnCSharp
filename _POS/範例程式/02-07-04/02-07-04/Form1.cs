using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _02_07_04
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
            //
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
            //新增DataRow方式C
            dtProduct.Rows.Add(new Object[] { "D8016", "Access 2007進銷存管理系統實作", 580, 36 });
            //加入主索引鍵
            dtProduct.PrimaryKey = new DataColumn[] { dtProduct.Columns["ProductID"] };
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //定義要修改的DataRow陣列
            DataRow[] drProduct;
            String currProductID, currProductName;
            String OldProductID, NewProductID, NewProductName;
            //尋找要被修改的商品記錄(以主索引鍵)
            OldProductID = Interaction.InputBox("請輸入要修改的書號?", 
                           "尋找修改的商品記錄", "", 0, 0);
            if (OldProductID == "")
            {
                return;
            }
            drProduct = dtProduct.Select("ProductID = '" + OldProductID + "'");
            //若DataRow陣列長度為0,代表找不到商品.
            if (drProduct.Length == 0)
            {
                MessageBox.Show("未找到要修改的商品!");
                return;
            }
            //將被修改的商品記錄的值來當預設值
            currProductID = (System.String)drProduct[0]["ProductID"];
            currProductName = (System.String)drProduct[0]["ProductName"];
            //輸入修改的值
            NewProductID = Interaction.InputBox("請輸入" + OldProductID +
                           "要修改成新的書號?", "商品資料表修改", 
                            currProductID, 0, 0);
            NewProductName = Interaction.InputBox("請輸入修改後的新書號" +
                             NewProductID + "的新書名?", "商品資料表修改", 
                             currProductName, 0, 0);
            //未輸入新值,以舊值做為修改的值.
            if (NewProductID == "")
            {
                NewProductID = currProductID;
            }
            if (NewProductName == "")
            {
                NewProductName = currProductName;
            }
            //開始修改
            drProduct[0].BeginEdit();
            //修改欄位的值
            drProduct[0]["ProductID"] = NewProductID;
            drProduct[0]["ProductName"] = NewProductName;
            //儲存變更
            drProduct[0].EndEdit();
        }
    }
}
