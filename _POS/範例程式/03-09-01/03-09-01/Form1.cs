using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_09_01
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
            //建立商品基本資料表
            CreateProductTable();

            //建立DataView->原本的資料
            DataView dvCurrentRows = new DataView(dtProduct);
            dvCurrentRows.RowStateFilter = DataViewRowState.CurrentRows;
            DataGridViewCurrentRows.DataSource = dvCurrentRows;

            //建立DataView->新增的資料
            DataView dvAdded = new DataView(dtProduct);
            dvAdded.RowStateFilter = DataViewRowState.Added;
            DataGridViewAdded.DataSource = dvAdded;

            //建立DataView->修改的資料
            DataView dvModifiedCurrent = new DataView(dtProduct);
            dvModifiedCurrent.RowStateFilter = DataViewRowState.ModifiedCurrent;
            DataGridViewModifiedCurrent.DataSource = dvModifiedCurrent;

            //建立DataView->刪除的資料
            DataView dvDeleted = new DataView(dtProduct);
            dvDeleted.RowStateFilter = DataViewRowState.Deleted;
            DataGridViewDeleted.DataSource = dvDeleted;

            //建立DataView->未異動的資料
            DataView dvUnchanged = new DataView(dtProduct);
            dvUnchanged.RowStateFilter = DataViewRowState.Unchanged;
            DataGridViewUnchanged.DataSource = dvUnchanged;

            //新增商品記錄
            dtProduct.Rows.Add(new Object[] { "P2297", "Visual Basic.Net進銷存程式設計" });
            dtProduct.Rows.Add(new Object[] { "P7117", "Visual Basic 2005程式設計" });
            dtProduct.Rows.Add(new Object[] { "P2057", "Delphi進銷存程式設計" });
            //認可更新
            dtProduct.AcceptChanges();
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
            //將欄位加入資料表
            dtProduct.Columns.Add(colProductID);
            dtProduct.Columns.Add(colProductName);
            //建立商品資料表的主索引鍵
            dtProduct.PrimaryKey = new DataColumn[] { colProductID };
        }

        private void btnAcceptChanges_Click(object sender, EventArgs e)
        {
            dtProduct.AcceptChanges();
        }

        private void btnRejectChanges_Click(object sender, EventArgs e)
        {
            dtProduct.RejectChanges();
        }
    }
}
