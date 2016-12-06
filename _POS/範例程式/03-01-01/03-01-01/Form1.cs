using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_01_01
{
    public partial class Form1 : Form
    {

        DataSet dsXIN;
        DataTable dtCustomer;
        UniqueConstraint ucCustomer;
        UniqueConstraint pkCustomer;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateCustomerTable();
            AddConstrains();
        }

        private void CreateCustomerTable()
        {
            dsXIN = new DataSet("XIN");
            dtCustomer = dsXIN.Tables.Add("Customer");
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
            //設定dataGridView控制項顯示dsXIN資料集裡的Customer資料表
            dataGridView1.DataSource = dsXIN;
            dataGridView1.DataMember = "Customer";
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

        //加入UniqueConstraint
        private void AddConstrains()
        {
            if (dtCustomer.Constraints.Count > 0)
            {
                return;
            }
            //Primary Key
            pkCustomer = new UniqueConstraint("CustomerID", 
                new DataColumn[] { dtCustomer.Columns["CustomerID"] }, true);
            dtCustomer.Constraints.Add(pkCustomer);
            listBox1.Items.Add("加入Primary條件約束");
            //Unique
            ucCustomer = new UniqueConstraint("CompanyName", 
                new DataColumn[] { dtCustomer.Columns["CompanyName"] });
            dtCustomer.Constraints.Add(ucCustomer);
            listBox1.Items.Add("加入Unique條件約束");
        }

        //移除UniqueConstraint
        private void RemoveConstrains(UniqueConstraint uc)
        {
            if (dtCustomer.Constraints.CanRemove(uc))
            {
                //使用Remove方法移除條件約束
                dtCustomer.Constraints.Remove(uc);
                listBox1.Items.Add(uc.ConstraintName + "移除");
            }
            else
            {
                listBox1.Items.Add(uc.ConstraintName + "不可移除");
            }
        }

        //清除UniqueConstraint
        private void ClearConstrains()
        {
            //清除前的條件約束數量
            listBox1.Items.Add("條件約束共有:" + 
                               dtCustomer.Constraints.Count + "個");
            dtCustomer.Constraints.Clear();
            //清除後的條件約束數量
            listBox1.Items.Add("條件約束共有:" + 
                               dtCustomer.Constraints.Count + "個");
        }

        //條件約束說明
        private void ConstrainsDescription()
        {
            foreach (UniqueConstraint uc in dtCustomer.Constraints)
            {
                listBox1.Items.Add("條件約束名稱 : " + uc.ConstraintName);
                listBox1.Items.Add("是否為Primary Key : " + uc.IsPrimaryKey);
                for (int i = 0; i <= uc.Columns.Count() - 1; i++)
                {
                    listBox1.Items.Add("條件約束欄位 : " + 
                                       uc.Columns[i].ColumnName);
                }
                listBox1.Items.Add("");
            }
        }

        private void btnConstraintsDescription_Click(object sender, EventArgs e)
        {
            ConstrainsDescription();
        }

        private void bntRemove_Click(object sender, EventArgs e)
        {
            UniqueConstraint pk;
            UniqueConstraint uc;
            pk = (UniqueConstraint)this.dtCustomer.Constraints[0];
            uc = (UniqueConstraint)this.dtCustomer.Constraints[1];
            RemoveConstrains(pk);
            RemoveConstrains(uc);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearConstrains();
        }

        private void btnAddConstraints_Click(object sender, EventArgs e)
        {
            AddConstrains();
        }
    }
}
