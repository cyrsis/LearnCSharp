using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_08_01
{
    public partial class Form1 : Form
    {

        DataSet dsXIN;
        DataTable dtCustomer;
        DataTable dtDelivery;
        DataRelation relation;
        BindingSource bsCustomer;
        DataViewManager dvmCustomer;
        DataView dvDelivery;   
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsXIN = new DataSet("XIN");
            CreateCustomerTable();
            CreateDeliveryTable();
            CreateRelation();
            CreateCustomerView();
            BindingData();
            bsCustomer.PositionChanged += new EventHandler(bsCustomer_PositionChanged);
            bsCustomer_PositionChanged(sender, e);
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

        private void BindingData()
        {
            //建立BindingSource物件
            bsCustomer = new BindingSource(dvmCustomer, "Customer");
            //設定TextBox控制項的資料繫結
            txtCustomerID.DataBindings.Add("Text", bsCustomer, "CustomerID");
            txtCompanyName.DataBindings.Add("Text", bsCustomer, "CompanyName");
            txtContact.DataBindings.Add("Text", bsCustomer, "Contact");
            txtPhone.DataBindings.Add("Text", bsCustomer, "Phone");
            txtFax.DataBindings.Add("Text", bsCustomer, "Fax");
            txtAddress.DataBindings.Add("Text", bsCustomer, "Address");
        }

        //建立關聯
        private void CreateRelation()
        {
            relation = dsXIN.Relations.Add("CustomerOrders",
                               dtCustomer.Columns["CustomerID"],
                               dtDelivery.Columns["CustomerID"]);
        }

        //建立父資料表的檢視
        private void CreateCustomerView()
        {
            dvmCustomer = new DataViewManager(dsXIN);
            dvmCustomer.DataViewSettings["Customer"].Sort = "CustomerID";
        }

        private void bsCustomer_PositionChanged(Object sender, EventArgs e)
        {
            btnMoveFirst.Enabled = (bsCustomer.Position > 0);
            btnMovePrevious.Enabled = (bsCustomer.Position > 0);
            btnMoveNext.Enabled = (bsCustomer.Position < bsCustomer.Count - 1);
            btnMoveLast.Enabled = (bsCustomer.Position < bsCustomer.Count - 1);
            //找出父資料表的DataRowView
            DataRowView drvCustomer;
            //使用DataViewManager建立DataRowView
            drvCustomer = (dvmCustomer.CreateDataView(dtCustomer))[bsCustomer.Position];
            //取得子資料表的檢視
            dvDelivery = drvCustomer.CreateChildView(relation);
            dvDelivery.Sort = "DeliveryID";
            dataGridView1.DataSource = dvDelivery;
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            bsCustomer.MoveFirst();
        }

        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            bsCustomer.MovePrevious();
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            bsCustomer.MoveNext();
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            bsCustomer.MoveLast();
        }
    }
}
