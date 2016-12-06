using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_07_01
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
            //商品名稱
            DataColumn colProductName = new DataColumn("ProductName");
            colProductName.DataType = System.Type.GetType("System.String");
            colProductName.MaxLength = 30;
            colProductName.AllowDBNull = false;
            //作者
            DataColumn colAuthor = new DataColumn("Author");
            colAuthor.DataType = System.Type.GetType("System.String");
            colAuthor.MaxLength = 10;
            //出版社
            DataColumn colStore = new DataColumn("Store");
            colStore.DataType = System.Type.GetType("System.String");
            colStore.MaxLength = 10;
            //將欄位加入資料表
            dtProduct.Columns.Add(colProductID);
            dtProduct.Columns.Add(colProductName);
            dtProduct.Columns.Add(colAuthor);
            dtProduct.Columns.Add(colStore);
            //建立商品資料表的主索引鍵
            dtProduct.PrimaryKey = new DataColumn[] { colProductID };
            //新增商品記錄
            dtProduct.Rows.Add(new Object[] { "P2297", "Visual Basic.Net進銷存程式設計", "阿惟", "文魁" });
            dtProduct.Rows.Add(new Object[] { "P7117", "Visual Basic 2005資料庫程式設計", "陳惟彬", "文魁" });
            dtProduct.Rows.Add(new Object[] { "P9999", "Access 2007進銷存管理系統實作", "陳惟彬", "文魁" });
            dtProduct.Rows.Add(new Object[] { "P3117", "ASP.NET會計系統程式設計", "陳惟彬", "文魁" });
            dtProduct.Rows.Add(new Object[] { "P8177", "ADO.NET 3.X資料庫程式設計參考手冊-適用VB.C#", "陳惟彬", "文魁" });
            dtProduct.Rows.Add(new Object[] { "P8287", "Visual Basic 2008網路程式設計", "陳惟彬", "文魁" });
            dtProduct.Rows.Add(new Object[] { "D09016", "SQL Server 2008設計與應用實務", "陳惟彬", "文魁" });
            dtProduct.Rows.Add(new Object[] { "XD10016", "Access 2010進銷存管理系統實作", "陳惟彬", "松崗" });
            dtProduct.Rows.Add(new Object[] { "XP11197", "Visual Basic 2010進銷存系統實作", "陳惟彬", "松崗" });
            comboField.Items.Add("ProductID");
            comboField.Items.Add("ProductName");
            comboField.Items.Add("Author");
            comboField.Items.Add("Store");
            DataGridView1.DataSource = dvProduct;
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            //加入要查詢的欄位
            String strField;
            strField = comboField.Text;
            int i;
            for (i = 0; i <= listField.Items.Count - 1; i++)
            {
                //被加入的欄位不可以是重覆的
                if (listField.Items[i].ToString() == strField)
                {
                    return;
                }
            }
            listField.Items.Add(strField);
        }

        private void btnClearField_Click(object sender, EventArgs e)
        {
            //清除要查詢的欄位
            listField.Items.Clear();
        }

        private void btnAddValue_Click(object sender, EventArgs e)
        {
            //加入要查詢的值
            listValue.Items.Add(txtValue.Text);
        }

        private void btnClearValue_Click(object sender, EventArgs e)
        {
            //清除要查詢的值
            listValue.Items.Clear();
        }

        private void btnFindRows_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            int i;
            //定義排序的欄位
            String strSortFields = "";
            for (i = 0; i <= listField.Items.Count - 1; i++)
            {
                strSortFields = strSortFields + listField.Items[i].ToString();
                if (i < listField.Items.Count - 1)
                {
                    strSortFields = strSortFields + ", ";
                }
            }
            //定義DataView的Sort
            dvProduct.Sort = strSortFields;
            ListBox1.Items.Add("排序的欄位" + dvProduct.Sort);
            ListBox1.Items.Add("");
            ListBox1.Items.Add("要找的值:");
            //找出要查詢值加入要查詢的字串陣列
            i = listValue.Items.Count - 1;
            String[] strFindValues = new String[listValue.Items.Count];
            for (i = 0; i <= listValue.Items.Count - 1; i++)
            {
                strFindValues[i] = listValue.Items[i].ToString();
                ListBox1.Items.Add(listValue.Items[i].ToString());
            }
            ListBox1.Items.Add("");
            //定義DataRowView
            DataRowView[] drvFindRows;
            //使用FindRow方法來查資料
            drvFindRows = dvProduct.FindRows(strFindValues);
            if (drvFindRows.Length == 0)
            {
                MessageBox.Show("找不到要尋找的資料!");
                return;
            }
            ListBox1.Items.Add("找到" + drvFindRows.Length.ToString() + "筆的記錄:");
            foreach (DataRowView drv in drvFindRows)
            {
                ListBox1.Items.Add(drv["ProductID"] + " " + drv["ProductName"] + " " +
                                   drv["Author"] + " " + drv["Store"]);
            }     
        }
    }
}
