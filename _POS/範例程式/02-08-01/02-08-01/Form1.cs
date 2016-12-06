using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_08_01
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
            //加入主索引鍵
            dtProduct.PrimaryKey = new DataColumn[] { dtProduct.Columns["ProductID"] };

            dtProduct.Rows.Add(new Object[] { "P8177", "ADO.NET 3.X資料庫程式設計參考手冊-適用VB.C#", 680, 3 });
            dtProduct.Rows.Add(new Object[] { "P8287", "Visual Basic 2008網路程式設計", 520, 6 });
            dtProduct.Rows.Add(new Object[] { "D09016", "SQL Server 2008設計與應用實務", 580, 12 });
        }

        //載入Xml文件
        private void btnReadXml_Click(object sender, EventArgs e)
        {
            //秀出開啟舊檔的對話方塊
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //按確定, 執行載入資料的動作
                //先清空目前DataTable的所有資料
                dtProduct.Clear();
                try
                {
                    //讀進XML文件檔
                    dsXIN.ReadXml(openFileDialog1.FileName);
                    //認可更新
                    dsXIN.AcceptChanges();
                }
                catch
                {
                    MessageBox.Show("檔案不存在或檔案開啟錯誤！");
                }
            }
        }

        //寫入Xml文件
        private void btnWriteXml_Click(object sender, EventArgs e)
        {
            //秀出儲存檔案的對話方塊
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //按確定, 執行寫入資料的動作
                dsXIN.WriteXml(saveFileDialog1.FileName);
            }
        }
    }
}
