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

namespace _02_07_05
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
            //新增DataRow方式
            dtProduct.Rows.Add(new Object[] { "P2297", "Visual Basic.Net進銷存程式設計", 580, 20 });
            dtProduct.Rows.Add(new Object[] { "P7117", "Visual Basic 2005資料庫程式設計", 6580, 30 });
            dtProduct.Rows.Add(new Object[] { "D8016", "Access 2007進銷存管理系統實作", 580, 36 });
            dtProduct.Rows.Add(new Object[] { "P8177", "ADO.NET 3.X資料庫程式設計參考手冊-適用VB.C#", 680, 3 });
            dtProduct.Rows.Add(new Object[] { "P8287", "Visual Basic 2008網路程式設計", 520, 6 });
            dtProduct.Rows.Add(new Object[] { "D09016", "SQL Server 2008設計與應用實務", 580, 12 });
            //加入主索引鍵
            dtProduct.PrimaryKey = new DataColumn[] { dtProduct.Columns["ProductID"] };
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDataRow(1);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DeleteDataRow(2);
        }

        private void DeleteDataRow(int DeleteType)
        {
            int intDeleteRowIndex;
            String strRowIndex;
            strRowIndex = Interaction.InputBox("請問您要刪除第幾筆記錄?\r\n" +
                               "輸入0以上的整數,-1為不刪除.", "刪除記錄", "-1", 0, 0);
            if ((strRowIndex == "") || (strRowIndex == "-1"))
            {
                return;
            }
            try
            {
                intDeleteRowIndex = Convert.ToInt32(strRowIndex);
                if ((intDeleteRowIndex >= 0) && 
                    (intDeleteRowIndex <= dtProduct.Rows.Count - 1))
                {
                    //從DataTable取出要刪除的DataRow
                    DataRow drDeleteRow = dtProduct.Rows[intDeleteRowIndex];
                    switch (DeleteType)
                    {
                        case 1:
                            //使用Delete()方法刪除DataRow
                            drDeleteRow.Delete();
                            break;
                        case 2:
                            //使用Remover()方法來移除DataRow
                            dtProduct.Rows.Remove(drDeleteRow);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("要刪除的記錄索引值不可大於總記錄數.");
                }
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("必須輸入一個整數!\r\n" + ex.Message);
            }
        }
    }
}
