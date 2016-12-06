using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_10_01
{
    public partial class Form1 : Form
    {

        DataSet dsXIN;
        DataTable dtCustomer;        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsXIN = new DataSet("XIN");
            CreateCustomerTable();
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
            DataGridView1.DataSource = dtCustomer;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            //定義客戶資料表變數
            DataTable dtCopy;
            if (radioCopy.Checked)
            {
                //複製客戶資料表所有的資料
                dtCopy = dtCustomer.Copy();
            }
            else
            {
                //只複製客戶資料表所有的結構
                dtCopy = dtCustomer.Clone();
            }
            //對目的資料表的名稱命名
            dtCopy.TableName = "CustomerCopy";
            //顯示目的資料表的記錄
            DataGridView2.DataSource = dtCopy;
            ListBox1.Items.Clear();
            ListBox1.Items.Add("複製資料表前的資料集內的資料表:");
            //秀出目前資料集裡的資料表
            ShowTables();
            //把目的資料表加入資料集
            dsXIN.Tables.Add(dtCopy);
            ListBox1.Items.Add("將複製的資料表加入資料集後,資料集內的資料表:");
            //秀出目前資料集裡的資料表
            ShowTables();
            //再把剛剛加入資料集的資料表移除
            dsXIN.Tables.Remove(dtCopy);
            ListBox1.Items.Add("將複製的資料表自資料集移除後,資料集內的資料表:");
            //秀出目前資料集裡的資料表
            ShowTables();
        }

        private void ShowTables()
        {
            int i;
            for (i = 0; i <= dsXIN.Tables.Count - 1; i++)
            {
                ListBox1.Items.Add(dsXIN.Tables[i].ToString());
            }
        }
    }
}
