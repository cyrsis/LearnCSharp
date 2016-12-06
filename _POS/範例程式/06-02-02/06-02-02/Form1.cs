using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _06_02_02
{
    public partial class Form1 : Form
    {
        
        SqlConnection cnSQL = new SqlConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cmdSQL = new SqlCommand();
        DataSet dsXIN = new DataSet();
        DataTable dtProduct = new DataTable();
        DataTable dtCustomer = new DataTable();
        DataTable dtSupplier = new DataTable(); 
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //定義連線字串
            cnSQL.ConnectionString = "Data Source=localhost;" +
                                     "Initial Catalog=XIN;" +
                                     "Integrated Security=SSPI;";
            //定義SqlCommand物件的SqlConnection物件
            cmdSQL.Connection = cnSQL;
            //指定SqlDataAdapter物件的SqlCommand物件
            adapter.SelectCommand = cmdSQL;
            //DataSet加入資料表
            dtProduct = dsXIN.Tables.Add("Product");
            dtCustomer = dsXIN.Tables.Add("Customer");
            dtSupplier = dsXIN.Tables.Add("Supplier");
            //定義SqlDataAdapter的Table名稱與實體資料表的名稱之對應
            adapter.TableMappings.Add("Table", "Product");
            adapter.TableMappings.Add("Table", "Customer");
            adapter.TableMappings.Add("Table", "Supplier");
        }

        private void btnDataSet_Click(object sender, EventArgs e)
        {
            //Fill(DataSet)
            dtProduct.Clear();
            cmdSQL.CommandText = "SELECT * FROM Product ";
            adapter.Fill(dsXIN);
            dataGridView1.DataSource = dsXIN;
            dataGridView1.DataMember = "Product";
        }

        private void btnDataTable_Click(object sender, EventArgs e)
        {
            //Fill(DataTable)
            dtCustomer.Clear();
            cmdSQL.CommandText = "SELECT * FROM Customer ";
            adapter.Fill(dtCustomer);
            dataGridView1.DataSource = dsXIN;
            dataGridView1.DataMember = "Customer";
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            //Fill(DataSet, 資料表名稱)
            dtSupplier.Clear();
            cmdSQL.CommandText = "SELECT * FROM Supplier ";
            adapter.Fill(dsXIN, "Supplier");
            dataGridView1.DataSource = dsXIN;
            dataGridView1.DataMember = "Supplier";
        }
    }
}
