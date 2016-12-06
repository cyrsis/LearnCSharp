using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_07_06
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

        private void button1_Click(object sender, EventArgs e)
        {
            //目前資料列的認可更新AcceptChanges()
            ProductAcceptChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //目前資料列的放棄更新RejecttChanges()
            ProductRejectChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //刪除目前資料列的商品記錄Delete()
            ProductDelete();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //刪除目前資料列的商品記錄Remove()
            ProductRemove();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //全部資料列的認可更新AcceptChanges()
            DataTableAcceptChanges();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //全部資料列的放棄更新RejecttChanges()
            DataTableRejectChanges();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //顯示資料列DataRow的RowState
            RowState();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //新增的資料列NewRow()
            AddNewRow();
        }

        private void ProductAcceptChanges()
        {
            //取得目前DataGridView1控制項所在的資料列
            int intRowIndex = dataGridView1.CurrentCell.RowIndex;
            //將目前所選擇的資料列做認可更新
            dtProduct.Rows[intRowIndex].AcceptChanges();
        }

        private void ProductRejectChanges()
        {
            //取得目前DataGridView1控制項所在的資料列
            int intRowIndex = dataGridView1.CurrentCell.RowIndex;
            //將目前所選擇的資料列做放棄更新
            dtProduct.Rows[intRowIndex].RejectChanges();
        }

        private void ProductDelete()
        {
            //取得目前DataGridView1控制項所在的資料列
            int intRowIndex = dataGridView1.CurrentCell.RowIndex;
            //將目前所選擇的資料列做Delete()
            dtProduct.Rows[intRowIndex].Delete();
        }

        private void ProductRemove()
        {
            //取得目前DataGridView1控制項所在的資料列
            int intRowIndex = dataGridView1.CurrentCell.RowIndex;
            //取出目前所選擇的DataRow
            DataRow RemoveDataRow = dtProduct.Rows[intRowIndex];
            //將目前所選擇的資料列做Remove
            dtProduct.Rows.Remove(RemoveDataRow);
        }

        private void DataTableAcceptChanges()
        {
            //資料表所有記錄都進行認可更新
            dtProduct.AcceptChanges();
        }

        private void DataTableRejectChanges()
        {
            //資料表所有記錄都放棄更新
            dtProduct.RejectChanges();
        }

        private void RowState()
        {
            int intDeleteRows = 0;
            listBox1.Items.Clear();
            foreach (DataRow ProductDataRow in dtProduct.Rows)
            {
                //刪除的記錄不允許直接存取
                if (ProductDataRow.RowState == DataRowState.Deleted)
                {
                    intDeleteRows += 1;
                }
                else
                {
                     listBox1.Items.Add("商品編號:" + ProductDataRow["ProductID"] +
                                        "的RowState:" + ProductDataRow.RowState);
                }
            }
            listBox1.Items.Add("商品資料表刪除的記錄數為:" + 
                               Convert.ToString(intDeleteRows));
            listBox1.Items.Add("商品資料表總記錄數為:" + 
                                Convert.ToString(dtProduct.Rows.Count));
        }

        private void AddNewRow()
        {
            //使用程式的方式新增記錄
            DataRow NewDataRow;
            NewDataRow = dtProduct.NewRow();
            NewDataRow["ProductID"] = textBox1.Text;
            NewDataRow["ProductName"] = textBox2.Text;
            listBox1.Items.Add("新增的DataRow但沒加入DataTable中," +
                               "商品編號:" + textBox1.Text +
                               "的RowState:" + NewDataRow.RowState);
            dtProduct.Rows.Add(NewDataRow);
            listBox1.Items.Add("新增的DataRow並已加入DataTable中," +
                               "商品編號:" + textBox1.Text +
                               "的RowState:" + NewDataRow.RowState);
        }


    }
}
