using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_04_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dsXIN = new DataSet("XIN");
            DataTable dtCustomer = dsXIN.Tables.Add("Customer");
            //建立欄位並加入客戶資料表
            dtCustomer.Columns.Add("CustomerID", typeof(String));
            dtCustomer.Columns.Add("CompanyName", typeof(String));
            dtCustomer.Columns.Add("Contact", typeof(String));
            dtCustomer.Columns.Add("Phone", typeof(String));
            dtCustomer.Columns.Add("Fax", typeof(String));
            dtCustomer.Columns.Add("Address", typeof(String));
            //客戶編號
            dtCustomer.Columns["CustomerID"].MaxLength = 8;
            dtCustomer.Columns["CustomerID"].AllowDBNull = false;
            //客戶名稱
            dtCustomer.Columns["CompanyName"].MaxLength = 40;
            dtCustomer.Columns["CompanyName"].AllowDBNull = false;
            dtCustomer.Columns["CompanyName"].Unique = true;
            //--其它欄位--
            //聯絡人
            dtCustomer.Columns["Contact"].MaxLength = 20;
            //電話
            dtCustomer.Columns["Phone"].MaxLength = 20;
            //傳真
            dtCustomer.Columns["Fax"].MaxLength = 20;
            //地址
            dtCustomer.Columns["Address"].MaxLength = 60;
            //設定DataGridView控制項顯示dsXIN資料集裡的Customer資料表
            dataGridView1.DataSource = dsXIN;
            dataGridView1.DataMember = "Customer";
        }
    }
}
