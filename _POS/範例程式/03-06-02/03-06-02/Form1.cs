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

namespace _03_06_02
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
            CreateDataView();
            CheckAllowEditOrAllowDelete();
            DataGridView1.DataSource = dvProduct;
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
            dtProduct.Rows.Add(new Object[] {"P2297", "Visual Basic.Net進銷存程式設計"});
            dtProduct.Rows.Add(new Object[] {"P7117", "Visual Basic 2005資料庫程式設計"});
            dtProduct.Rows.Add(new Object[] {"D8016", "Access 2007進銷存管理系統實作"});
            dtProduct.Rows.Add(new Object[] {"P8177", "ADO.NET 3.X資料庫程式設計參考手冊-適用VB.C#"});
            dtProduct.Rows.Add(new Object[] {"P8287", "Visual Basic 2008網路程式設計"});
            dtProduct.Rows.Add(new Object[] {"D09016", "SQL Server 2008設計與應用實務" });
        }

        private void CreateDataView()
        {
            //建立DataView
            dvProduct = dtProduct.DefaultView;
            //定義排序欄位
            dvProduct.Sort = "ProductID";
        }

        private void EditProduct()
        {
            if (!dvProduct.AllowEdit)
            {
                MessageBox.Show("DataView不允許修改!");
                return;
            }
            String DefaultProductID, DefaultProductName;
            String OldModifyProdutID, ModifyProductID, ModifyProductName;
            //尋找要被修改的商品記錄
            OldModifyProdutID = Interaction.InputBox(
                "請輸入要修改的書號?", "尋找修改的商品記錄", "", 0, 0);
            if (OldModifyProdutID == "")
            {
                return;
            }
            int rowIndex = dvProduct.Find(OldModifyProdutID);
            if (rowIndex == -1)
            {
                MessageBox.Show("未找到要修改的商品!");
                return;
            }
            //定義要修改的DataRowView
            DataRowView drvProduct;
            drvProduct = dvProduct[rowIndex];
            //將被修改的商品記錄的值來當預設值
            DefaultProductID = (String)drvProduct["ProductID"];
            DefaultProductName = (String)drvProduct["ProductName"];
            //輸入修改的值
            ModifyProductID = Interaction.InputBox("請輸入" + OldModifyProdutID +
                                   "要修改成新的書號?", "商品資料表修改",
                                   DefaultProductID, 0, 0);
            ModifyProductName = Interaction.InputBox("請輸入修改後的新書號" + 
                                ModifyProductID + "的新書名?", "商品資料表修改", 
                                DefaultProductName, 0, 0);
            //未輸入新值,以舊值做為修改的值.
            if (ModifyProductID == "")
            {
                ModifyProductID = DefaultProductID;
            }
            if (ModifyProductName == "")
            {
                ModifyProductName = DefaultProductName;
            }
            //開始修改
            drvProduct.BeginEdit();
            //修改欄位的值
            drvProduct["ProductID"] = ModifyProductID;
            drvProduct["ProductName"] = ModifyProductName;

            if (MessageBox.Show("儲存對商品資料的變更?", "儲存?", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //儲存變更
                drvProduct.EndEdit();
            }
            else
            {
                //取消變更
                drvProduct.CancelEdit();
            }
        }

        private void DeleteProduct()
        {
            if (!dvProduct.AllowDelete)
            {
                MessageBox.Show("DataView不允許刪除!");
                return;
            }
            String DeleteModifyProdutID;
            //尋找要被修改的商品記錄
            DeleteModifyProdutID = Interaction.InputBox(
                "請輸入要刪除的書號?", "尋找修改的商品記錄", "", 0, 0);
            if (DeleteModifyProdutID == "")
            {
                return;
            }
            int rowIndex = dvProduct.Find(DeleteModifyProdutID);
            if (rowIndex == -1)
            {
                MessageBox.Show("未找到要刪除的商品!");
                return;
            }
            //定義要刪除的DataRowView
            DataRowView drvProduct;
            drvProduct = dvProduct[rowIndex];
            //刪除記錄
            drvProduct.Delete();
        }

        private void CheckAllowEditOrAllowDelete()
        {
            dvProduct.AllowEdit = cbAllowEdit.Checked;
            dvProduct.AllowDelete = cbAllowDelete.Checked;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditProduct();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        private void cbAllowDelete_Click(object sender, EventArgs e)
        {
            CheckAllowEditOrAllowDelete();
        }

        private void cbAllowEdit_Click(object sender, EventArgs e)
        {
            CheckAllowEditOrAllowDelete();
        }
    }
}
