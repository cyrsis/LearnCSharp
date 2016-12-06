using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_05_01
{
    public partial class Form1 : Form
    {

        DataSet dsXIN;
        DataTable dtCustomer;
        BindingSource bsCustomer;
        DataViewManager dvmCustomer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsXIN = new DataSet("XIN");
            CreateCustomerTable();
            CreateCustomerView();
            BindingData();
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

        private void CreateCustomerView()
        {
            dvmCustomer = new DataViewManager();
            dvmCustomer.DataSet = dsXIN;
        }

        private void BindingData()
        {
            //建立BindingSource物件
            bsCustomer = new BindingSource(dsXIN, "Customer");
            //設定TextBox控制項的資料繫結
            txtCustomerID.DataBindings.Add("Text", bsCustomer, "CustomerID");
            txtCompanyName.DataBindings.Add("Text", bsCustomer, "CompanyName");
            txtContact.DataBindings.Add("Text", bsCustomer, "Contact");
            txtPhone.DataBindings.Add("Text", bsCustomer, "Phone");
            txtFax.DataBindings.Add("Text", bsCustomer, "Fax");
            txtAddress.DataBindings.Add("Text", bsCustomer, "Address");
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            //第一筆
            bsCustomer.MoveFirst();
        }

        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            //上一筆
            bsCustomer.MovePrevious();
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            //下一筆
            bsCustomer.MoveNext();
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            //最後一筆
            bsCustomer.MoveLast();
        }
    }
}
