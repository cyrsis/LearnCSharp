using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_06_01
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
            dvProduct.AllowNew = cbAllowNew.Checked;
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
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (!dvProduct.AllowNew)
            {
                MessageBox.Show("DataView不允許新增DataRowView!");
                return;
            }
            //建立DataRowView
            DataRowView drvProduct = dvProduct.AddNew();
            CheckIsNewOrIsEdit(drvProduct);
            drvProduct["ProductID"] = txtProductID.Text;
            drvProduct["ProductName"] = txtProductName.Text;
            //儲存編輯
            drvProduct.EndEdit();
            CheckIsNewOrIsEdit(drvProduct);
        }

        private void CheckIsNewOrIsEdit(DataRowView drv)
        {
            ListBox1.Items.Add("本筆記錄是否為新增:" + drv.IsNew);
            ListBox1.Items.Add("本筆記錄是否為修改:" + drv.IsEdit);
        }

        private void cbAllowNew_Click(object sender, EventArgs e)
        {
            dvProduct.AllowNew = cbAllowNew.Checked; 
        }
    }
}
