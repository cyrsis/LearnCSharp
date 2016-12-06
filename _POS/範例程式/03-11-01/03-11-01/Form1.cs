using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_11_01
{
    public partial class Form1 : Form
    {

        DataSet dsXIN;
        DataTable dtCustomer;
        DataTable dtDelivery;
        DataTable dtDeliveryDetails;
        DataTable dtProduct;
        BindingSource bsDelivery;
        BindingSource bsDeliveryDetails;      

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsXIN = new DataSet("XIN");
            CreateProductTable();
            CreateCustomerTable();
            CreateDeliveryTable();
            CreateDeliveryDetailsTable();
            CreateDeliveryDetailsAggregateDataColumn();
            CreateConstraints();
            CreateRelation();
            CreateDeliveryAggregateDataColumn();
            AddDeliveryDetails();
            BindingData();
            bsDelivery.PositionChanged += new EventHandler(bsDelivery_PositionChanged);
        }

        private void bsDelivery_PositionChanged(Object sender, EventArgs e)
        {
            btnMoveFirst.Enabled = (bsDelivery.Position > 0);
            btnMovePrevious.Enabled = (bsDelivery.Position > 0);
            btnMoveNext.Enabled = (bsDelivery.Position < bsDelivery.Count - 1);
            btnMoveLast.Enabled = (bsDelivery.Position < bsDelivery.Count - 1);
        }

        private void CreateProductTable()
        {
            dtProduct = new DataTable("Product");
            dsXIN.Tables.Add(dtProduct);
            //商品編號
            DataColumn colProductID = new DataColumn("ProductID");
            colProductID.DataType = System.Type.GetType("System.String");
            colProductID.MaxLength = 10;
            //商品名稱
            DataColumn colProductName = new DataColumn("ProductName");
            colProductName.DataType = System.Type.GetType("System.String");
            colProductName.MaxLength = 50;
            //將欄位加入資料表
            dtProduct.Columns.Add(colProductID);
            dtProduct.Columns.Add(colProductName);
            //建立商品資料表的主索引鍵
            dtProduct.PrimaryKey = new DataColumn[] { colProductID };
            //新增商品記錄
            dtProduct.Rows.Add(new Object[] { "P2297", "Visual Basic.Net進銷存程式設計" });
            dtProduct.Rows.Add(new Object[] { "P7117", "Visual Basic 2005資料庫程式設計"});
            dtProduct.Rows.Add(new Object[] { "D8016", "Access 2007進銷存管理系統實作" });
            dtProduct.Rows.Add(new Object[] { "P2057", "Delphi進銷存程式設計"});
            dtProduct.Rows.Add(new Object[] { "P3117", "ASP.NET會計系統程式設計" });
            dtProduct.Rows.Add(new Object[] { "P4107", "C++ Builder資料庫程式設計人事薪資系統實作" });
            dtProduct.Rows.Add(new Object[] { "D09016", "SQL Server 2008設計與應用實務" });
            dtProduct.Rows.Add(new Object[] { "P8177", "ADO.NET 3.X資料庫程式設計參考手冊-適用VB.C#" });
            dtProduct.Rows.Add(new Object[] { "XP11197", "Visual Basic 2010 資料庫程式設計暨進銷存會計系統實作" });
            dtProduct.Rows.Add(new Object[] { "XD10016", "Access 2010進銷存管理系統實作" });
            dtProduct.Rows.Add(new Object[] { "P8287", "Visual Basic 2008網路程式設計" });
            dtProduct.Rows.Add(new Object[] { "XP10027", "趣味玩轉樂高機器人-使用Microsoft Robotics Developer Studio" });
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
            //建立欄位並加入客戶資料表
            dtCustomer.Columns.Add(colCustomerID);
            dtCustomer.Columns.Add(colCompanyName);
            dtCustomer.Rows.Add(new Object[] { "001", "三星科技股份有限公司" });
            dtCustomer.Rows.Add(new Object[] { "002", "金屬工業研究發展中心" });
            dtCustomer.Rows.Add(new Object[] { "003", "普愛資訊管理股份有限公司" });
            dtCustomer.Rows.Add(new Object[] { "004", "國立屏東科技大學" });
            dtCustomer.Rows.Add(new Object[] { "005", "肯高國際" });
        }

        private void CreateDeliveryTable()
        {
            dtDelivery = new DataTable("Delivery");
            dsXIN.Tables.Add(dtDelivery);
            //出貨編號
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
            colCustomerID.AllowDBNull = false;
            dtDelivery.Columns.Add(colDeliveryID);
            dtDelivery.Columns.Add(colDeliveryDate);
            dtDelivery.Columns.Add(colCustomerID);
            //隨機新增100筆出貨單
            int i;
            DataRow drNewRow;
            Random rnd = new Random();
            for (i = 1; i <= 100; i++)
            {
                int intCutomerID = rnd.Next(1, 6);
                drNewRow = dtDelivery.NewRow();
                drNewRow["CustomerID"] = "00" + Convert.ToString(intCutomerID);
                dtDelivery.Rows.Add(drNewRow);
            }
        }

        private void CreateDeliveryDetailsTable()
        {
            dtDeliveryDetails = new DataTable("DeliveryDetails");
            dsXIN.Tables.Add(dtDeliveryDetails);
            //出貨單號
            DataColumn colDeliveryID = new DataColumn("DeliveryID");
            colDeliveryID.DataType = System.Type.GetType("System.Int32");
            //商品編號
            DataColumn colProductID = new DataColumn("ProductID");
            colProductID.DataType = System.Type.GetType("System.String");
            colProductID.MaxLength = 10;
            colProductID.AllowDBNull = false;
            //數量
            DataColumn colQuantity = new DataColumn("Quantity");
            colQuantity.DataType = System.Type.GetType("System.Int32");
            colQuantity.DefaultValue = 0;
            colQuantity.AllowDBNull = false;
            //價格
            DataColumn colPrice = new DataColumn("Price");
            colPrice.DataType = System.Type.GetType("System.Int32");
            colPrice.DefaultValue = 0;
            colPrice.AllowDBNull = false;
            //將欄位加入dtDeliveryDetails
            dtDeliveryDetails.Columns.Add(colDeliveryID);
            dtDeliveryDetails.Columns.Add(colProductID);
            dtDeliveryDetails.Columns.Add(colQuantity);
            dtDeliveryDetails.Columns.Add(colPrice);
        }

        //建立條件約束
        private void CreateConstraints()
        {
            //建立客戶資料表與出貨單資料表的資料完整性
            ForeignKeyConstraint fkCustomer_Delivery =
                new ForeignKeyConstraint("FK_Customer_Delivery",
                    dtCustomer.Columns["CustomerID"], dtDelivery.Columns["CustomerID"]);
            dtDelivery.Constraints.Add(fkCustomer_Delivery);
            //建立商品資料表與出貨單明細資料表的資料完整性
            ForeignKeyConstraint fkProduct_DeliveryDetails =
                new ForeignKeyConstraint("FK_Product_DeliveryDetails",
                    dtProduct.Columns["ProductID"], dtDeliveryDetails.Columns["ProductID"]);
            dtDeliveryDetails.Constraints.Add(fkProduct_DeliveryDetails);
        }

        //建立關聯
        private void CreateRelation()
        {
            dsXIN.Relations.Add("DeliveryDeliveryDetails",
                                dtDelivery.Columns["DeliveryID"],
                                dtDeliveryDetails.Columns["DeliveryID"]);
        }

        private void BindingData()
        {
            //建立BindingSource物件
            //出貨單主資料表
            bsDelivery = new BindingSource(dsXIN, "Delivery");
            //出貨單明細資料表;
            bsDeliveryDetails = new BindingSource(bsDelivery, "DeliveryDeliveryDetails");
            //設定控制項的資料繫結
            dtpDeliveryDate.DataBindings.Add("Value", bsDelivery, "DeliveryDate");
            txtCustomerID.DataBindings.Add("Text", bsDelivery, "CustomerID");
            txtDeliveryID.DataBindings.Add("Text", bsDelivery, "DeliveryID");
            txtSubTotal.DataBindings.Add("Text", bsDelivery, "SubTotal");
            txtTax.DataBindings.Add("Text", bsDelivery, "Tax");
            txtAmount.DataBindings.Add("Text", bsDelivery, "Amount");
            //設定DataGridView控制項顯示Delivery父資料表關聯的DeliveryDetails子資料表
            ChildDataGridView.DataSource = bsDeliveryDetails;
            //設定DataGridView控制項的欄位抬頭
            ChildDataGridView.Columns["DeliveryID"].HeaderText = "出貨單號";
            ChildDataGridView.Columns["ProductID"].HeaderText = "商品編號";
            ChildDataGridView.Columns["Quantity"].HeaderText = "數量";
            ChildDataGridView.Columns["Price"].HeaderText = "價格";
            ChildDataGridView.Columns["Amount"].HeaderText = "金額";
            //出貨單號與金額不允許使用者修改
            ChildDataGridView.Columns["DeliveryID"].ReadOnly = true;
            ChildDataGridView.Columns["Amount"].ReadOnly = true;
        }

        //建立出貨單明細資料表的計算欄位
        private void CreateDeliveryDetailsAggregateDataColumn()
        {
            //小計金額
            DataColumn colAmount = new DataColumn("Amount");
            colAmount.DataType = System.Type.GetType("System.Int32");
            colAmount.Expression = "Quantity * Price";
            dtDeliveryDetails.Columns.Add(colAmount);
        }

        //建立出貨單資料表的計算欄位
        private void CreateDeliveryAggregateDataColumn()
        {
            //銷售金額
            DataColumn colSubTotal = new DataColumn("SubTotal");
            colSubTotal.DataType = System.Type.GetType("System.Int32");
            colSubTotal.Expression = "Sum(Child.Amount)";
            //5%稅額
            DataColumn colTax = new DataColumn("Tax");
            colTax.DataType = System.Type.GetType("System.Int32");
            colTax.Expression = "Sum(Child.Amount) * 0.05";
            //總計金額
            DataColumn colAmount = new DataColumn("Amount");
            colAmount.DataType = System.Type.GetType("System.Int32");
            colAmount.Expression = "Sum(Child.Amount) + Sum(Child.Amount) * 0.05";
            dtDelivery.Columns.Add(colSubTotal);
            dtDelivery.Columns.Add(colTax);
            dtDelivery.Columns.Add(colAmount);
        }

        //隨機新增每一筆出貨單的出貨明細
        private void AddDeliveryDetails()
        {
            int i;
            Random rnd = new Random();
            bool[] blnBooks = new bool[13];
            DataRow drNewRow;
            //新增測試資料
            foreach (DataRow dr in dtDelivery.Rows)
            {
                //每項商品都設為尚未出貨
                for (i = 1; i <= 12; i++)
                {
                    blnBooks[i] = false;
                }
                //決定出貨明細的數量
                int intCounts = rnd.Next(1, 10);
                //新增出貨明細
                for (i = 1; i <= intCounts; i++)
                {
                    int intProduct = 1;
                    bool SelectBook = false;
                    //選擇商品編號
                    while (!SelectBook)
                    {
                        intProduct = rnd.Next(1, 12);
                        //判斷商品編號是否已採購
                        if (blnBooks[intProduct] == false)
                        {
                            SelectBook = true;
                            blnBooks[intProduct] = true;
                        }
                    }
                    drNewRow = dtDeliveryDetails.NewRow();
                    drNewRow["DeliveryID"] = dr["DeliveryID"];
                    //新增每一筆出貨明細的商品編號
                    switch (intProduct)
                    {
                        case 1:
                            drNewRow["ProductID"] = "P2297";
                            break;
                        case 2:
                            drNewRow["ProductID"] = "P7117";
                            break;
                        case 3:
                            drNewRow["ProductID"] = "D8016";
                            break;
                        case 4:
                            drNewRow["ProductID"] = "P2057";
                            break;
                        case 5:
                            drNewRow["ProductID"] = "P3117";
                            break;
                        case 6:
                            drNewRow["ProductID"] = "P4107";
                            break;
                        case 7:
                            drNewRow["ProductID"] = "D09016";
                            break;
                        case 8:
                            drNewRow["ProductID"] = "P8177";
                            break;
                        case 9:
                            drNewRow["ProductID"] = "XP11197";
                            break;
                        case 10:
                            drNewRow["ProductID"] = "XD10016";
                            break;
                        case 11:
                            drNewRow["ProductID"] = "P8287";
                            break;
                        case 12:
                            drNewRow["ProductID"] = "XP10027";
                            break;
                    }
                    //數量(1~10)
                    drNewRow["Quantity"] = rnd.Next(1, 10);
                    //價格(500~700)
                    drNewRow["Price"] = rnd.Next(500, 700);
                    dtDeliveryDetails.Rows.Add(drNewRow);
                }
            }
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            bsDelivery.MoveFirst();
        }

        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            bsDelivery.MovePrevious();
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            bsDelivery.MoveNext();
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            bsDelivery.MoveLast();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            bsDelivery.AddNew();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bsDelivery.RemoveCurrent();
        }

        private void btnEndEdit_Click(object sender, EventArgs e)
        {
            bsDelivery.EndEdit();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            bsDelivery.CancelEdit();
        }
    }
}
