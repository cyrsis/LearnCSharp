using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_05_03
{
    public partial class Form1 : Form
    {

        DataSet dsXIN;
        DataTable dtCustomer;
        DataTable dtDelivery;
        DataTable dtProduct;
        DataView MyDataView;        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsXIN = new DataSet("XIN");
            CreateCustomerTable();
            CreateDeliveryTable();
            CreateProductTable();
            UpdateRowFilterDataColumn();
        }

        private void CreateCustomerTable()
        {
            dtCustomer = new DataTable("Customer");
            dsXIN.Tables.Add(dtCustomer);
            //客戶編號
            DataColumn colCustomerID = new DataColumn("CustomerID");
            colCustomerID.DataType = System.Type.GetType("System.String");
            colCustomerID.MaxLength = 8;
            colCustomerID.AllowDBNull = false;
            //公司名稱
            DataColumn colCompanyName = new DataColumn("CompanyName");
            colCompanyName.DataType = System.Type.GetType("System.String");
            colCompanyName.MaxLength = 40;
            colCompanyName.AllowDBNull = false;
            //連絡人
            DataColumn colContact = new DataColumn("Contact");
            colContact.DataType = System.Type.GetType("System.String");
            colContact.MaxLength = 12;
            colContact.AllowDBNull = false;
            //電話
            DataColumn colPhone = new DataColumn("Phone");
            colPhone.DataType = System.Type.GetType("System.String");
            colPhone.MaxLength = 20;
            //傳真
            DataColumn colFax = new DataColumn("Fax");
            colFax.DataType = System.Type.GetType("System.String");
            colFax.MaxLength = 20;
            //地址
            DataColumn colAddress = new DataColumn("Address");
            colAddress.DataType = System.Type.GetType("System.String");
            colAddress.MaxLength = 60;
            //建立欄位並加入客戶資料表
            dtCustomer.Columns.Add(colCustomerID);
            dtCustomer.Columns.Add(colCompanyName);
            dtCustomer.Columns.Add(colContact);
            dtCustomer.Columns.Add(colPhone);
            dtCustomer.Columns.Add(colFax);
            dtCustomer.Columns.Add(colAddress);

            dtCustomer.PrimaryKey = new DataColumn[] { colCustomerID };

            dtCustomer.Rows.Add(new Object[] { "SS", "三星科技股份有限公司",
                            "陳政輝", "06-2306611", "06-2306000", 
                            "台南縣歸仁鄉南興村中山路三段355-6號" });
            dtCustomer.Rows.Add(new Object[] { "MIRDC", "金屬工業研究發展中心",
                            "徐學慈", "07-3513121", "07-3527246",
                            "高雄市楠梓區高楠公路1001號" });
            dtCustomer.Rows.Add(new Object[] {"PLX", "普愛資訊管理股份有限公司", 
                            "潘委倫", "09-3293019", 
                            "09-3293020", "台北市內湖區中正路200號20樓"});
            dtCustomer.Rows.Add(new Object[] { "SATALL", "薩托爾貿易有限公司",
                            "鄭宏輝", "02-68902902", "02-68902904",
                            "基隆市東光路三段25號" });
            dtCustomer.Rows.Add(new Object[] {"TEMP", "暫時科技有限公司", 
                            "鄭宏輝", "02-33789512", 
                            "02-33789515", "台北市中正區中強路109號33樓"});
        }

        private void CreateDeliveryTable()
        {
            dtDelivery = new DataTable("Delivery");
            dsXIN.Tables.Add(dtDelivery);
            //出貨單號
            DataColumn colDeliveryID = new DataColumn("DeliveryID");
            colDeliveryID.DataType = System.Type.GetType("System.Int32");
            colDeliveryID.AutoIncrement = true;
            colDeliveryID.AutoIncrementSeed = 1;
            colDeliveryID.AutoIncrementStep = 1;
            //出貨日期
            DataColumn colDeliveryDate = new DataColumn("DeliveryDate");
            colDeliveryDate.DataType = System.Type.GetType("System.DateTime");
            colDeliveryDate.DefaultValue = DateTime.Today;
            colDeliveryDate.AllowDBNull = false;
            //客戶編號
            DataColumn colCustomerID = new DataColumn("CustomerID");
            colCustomerID.DataType = System.Type.GetType("System.String");
            colCustomerID.MaxLength = 8;
            colCustomerID.DefaultValue = "Unknow";
            //colCustomerID.AllowDBNull = false;
            dtDelivery.Columns.Add(colDeliveryID);
            dtDelivery.Columns.Add(colDeliveryDate);
            dtDelivery.Columns.Add(colCustomerID);
            //隨機新增出貨單
            int i, j;
            DataRow drNewRow;
            j = 0;
            for (i = 1; i <= 10; i++)
            {
                drNewRow = dtDelivery.NewRow();
                j++;
                if (j == 1)
                {
                    drNewRow["CustomerID"] = "SS";
                }
                else if (j == 2)
                {
                    drNewRow["CustomerID"] = "MIRDC";
                }
                else
                {
                    drNewRow["CustomerID"] = "PLX";
                    j = 0;
                }
                dtDelivery.Rows.Add(drNewRow);
            }
        }

        private void CreateProductTable()
        {
            dtProduct = new DataTable("Product");
            dsXIN.Tables.Add(dtProduct);
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
        }

        private void UpdateRowFilterDataColumn()
        {
            DataTable dt;
            if (radioCustomerTable.Checked)
            {
                dt = dtCustomer;
            }
            else if (radioProductTable.Checked)
            {
                dt = dtProduct;
            }
            else
            {
                dt = dtDelivery;
            }
            //清除ComboBox內的欄位清單
            cboRowFilterColumn.Items.Clear();
            cboSortDataColumn.Items.Clear();
            //把欄位名稱加入ComboBox
            int i;
            for (i = 0; i <= dt.Columns.Count - 1; i++)
            {
                cboRowFilterColumn.Items.Add(dt.Columns[i].ColumnName);
                cboSortDataColumn.Items.Add(dt.Columns[i].ColumnName);
            }
            //預設第1個欄位
            cboRowFilterColumn.SelectedIndex = 0;
            cboSortDataColumn.SelectedIndex = 0;
        }

        private void ApplyRowFilterAndSort()
        {
            if (radioCustomerTable.Checked)
            {
                MyDataView = dtCustomer.DefaultView;
            }
            else if (radioProductTable.Checked)
            {
                MyDataView = dtProduct.DefaultView;
            }
            else
            {
                MyDataView = dtDelivery.DefaultView;
            }
            if (txtRowFilterValue.Text != "")
            {
                //儲存RowFilter運算式的字串變數
                String strFilter, strCalc, strVxy;
                //找出運算子
                if (RadioButton1.Checked)
                {
                    strCalc = ">";
                }
                else if (RadioButton2.Checked)
                {
                    strCalc = ">=";
                }
                else if (RadioButton3.Checked)
                {
                    strCalc = "=";
                }
                else if (RadioButton4.Checked)
                {
                    strCalc = "<";
                }
                else if (RadioButton5.Checked)
                {
                    strCalc = "<=";
                }
                else if (RadioButton6.Checked)
                {
                    strCalc = "<>";
                }
                else if (RadioButton7.Checked)
                {
                    strCalc = "IN";
                }
                else
                {
                    strCalc = "Like";
                }
                if (cboRowFilterColumn.Text == "DeliveryDate")
                {
                    //日期欄位
                    strVxy = "#";
                }
                else if (cboRowFilterColumn.Text == "Quantity")
                {
                    //數值欄位
                    strVxy = "";
                }
                else
                {
                    //文字欄位
                    strVxy = "'";
                }
                //組合RowFilter屬性
                if (strCalc != "IN")
                {
                    strFilter = cboRowFilterColumn.Text + " " + strCalc + " " +
                                strVxy + txtRowFilterValue.Text + strVxy;
                }
                else
                {
                    //如果運算子為IN,取出ListBox內每一個條件
                    strFilter = cboRowFilterColumn.Text + " IN (";
                    int j;
                    for (j = 0; j <= ListBox1.Items.Count - 1; j++)
                    {
                        strFilter = strFilter + strVxy +
                                    ListBox1.Items[j] + strVxy;
                        if (j < ListBox1.Items.Count - 1)
                        {
                            strFilter = strFilter + ", ";
                        }
                    }
                    strFilter = strFilter + ")";
                }
                MyDataView.RowFilter = strFilter;
            }
            else
            {
                MyDataView.RowFilter = "";
            }
            //排序方向
            if (radioASC.Checked)
            {
                MyDataView.Sort = cboSortDataColumn.Text;
            }
            else if (radioDESC.Checked)
            {
                MyDataView.Sort = cboSortDataColumn.Text + " DESC";
            }
            else
            {
                MyDataView.Sort = "";
                MyDataView.ApplyDefaultSort = true;
            }
            txtRowFilter.Text = MyDataView.RowFilter;
            txtSort.Text = MyDataView.Sort;
            DataGridView1.DataSource = MyDataView;
        }

        private void radioCustomerTable_Click(object sender, EventArgs e)
        {
            UpdateRowFilterDataColumn();
        }

        private void radioProductTable_Click(object sender, EventArgs e)
        {
            UpdateRowFilterDataColumn();
        }

        private void radioDeliveryTable_Click(object sender, EventArgs e)
        {
            UpdateRowFilterDataColumn();
        }

        private void btnApplyRowFilterAndSort_Click(object sender, EventArgs e)
        {
            ApplyRowFilterAndSort();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtRowFilterValue.Text != "")
            {
                ListBox1.Items.Add(txtRowFilterValue.Text);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
        }
    }
}
