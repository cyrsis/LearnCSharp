using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_03_01
{
    public partial class Form1 : Form
    {

        DataSet dsXIN;
        DataTable dtCustomer;
        DataTable dtDelivery;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsXIN = new DataSet("XIN");
            CreateCustomerTable();
            CreateDeliveryTable();
            CreateConstraints();
            SetRelationControl();
        }

        private void SetDataTableRelations()
        {
            //建立關聯
            dsXIN.Relations.Add("FK_Customer_Delivery",
                dtCustomer.Columns["CustomerID"], dtDelivery.Columns["CustomerID"]);
        }   

        private void SetRelationControl()
        {
            //設定DataGridView1控制項顯示dsXIN資料集裡的Customer資料表
            dataGridView1.DataSource = dsXIN;
            dataGridView1.DataMember = "Customer";
            //顯示訂購單資料
            //原來的寫法:
            //dataGridView2.DataSource = dsXIN;
            //dataGridView2.DataMember = "Delivery";
            //顯示關聯的子資料表,須修改如下:
            //設定DataGridView2控制項顯示Customer父資料表關聯的Delivery子資料表
            dataGridView2.DataSource = dsXIN;
            dataGridView2.DataMember = "Customer.FK_Customer_Delivery";
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
            //設定DataGridView控制項顯示dsXIN資料集裡的Delivery資料表
            dataGridView2.DataSource = dsXIN;
            dataGridView2.DataMember = "Delivery";
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

        //建立條件約束
        private void CreateConstraints()
        {
            //建立客戶資料表的主索引鍵
            UniqueConstraint pkCustomer = 
                new UniqueConstraint(new DataColumn[]
                {dtCustomer.Columns["CustomerID"]}, true);
            dtCustomer.Constraints.Add(pkCustomer);
            //建立出貨單資料表的主索引鍵
            UniqueConstraint pkDelivery = 
                new UniqueConstraint(new DataColumn[]
                {dtDelivery.Columns["DeliveryID"]}, true);
            dtDelivery.Constraints.Add(pkDelivery);
            //建立客戶資料表與出貨單資料表的資料完整性
            ForeignKeyConstraint fkCustomer_Delivery = 
                new ForeignKeyConstraint("FK_Customer_Delivery", 
                    dtCustomer.Columns["CustomerID"], 
                    dtDelivery.Columns["CustomerID"]);
            dtDelivery.Constraints.Add(fkCustomer_Delivery);
            //
            SetDataTableRelations();
        }
    }
}
