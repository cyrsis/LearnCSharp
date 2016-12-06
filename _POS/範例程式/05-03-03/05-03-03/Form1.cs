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

namespace _05_03_03
{
    public partial class Form1 : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();   
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "Data Source=localhost;" +
                                     "Initial Catalog=XIN;" +
                                     "Integrated Security=True;";
            cmd.Connection = cn;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT SUM(UnitPrice * Quantity) " +
                              "FROM DeliveryDetails ";
            int intAmount;
            cn.Open();
            intAmount = Convert.ToInt32(cmd.ExecuteScalar());
            listBox1.Items.Add("統計出貨金額:" + intAmount.ToString("#,##0"));
            cn.Close();
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT AVG(UnitPrice * Quantity) " +
                              "FROM DeliveryDetails ";
            Decimal avgAmount;
            cn.Open();
            avgAmount = Convert.ToDecimal(cmd.ExecuteScalar());
            listBox1.Items.Add("平均出貨金額:" + avgAmount.ToString("#,##0.00"));
            cn.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT MAX(Amount) " + 
                              "FROM Delivery ";
            int maxAmount;
            cn.Open();
            maxAmount = Convert.ToInt32(cmd.ExecuteScalar());
            listBox1.Items.Add("最大出貨金額:" + maxAmount.ToString("#,##0"));
            cn.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT MIN(Amount) " +
                              "FROM Delivery ";
            int minAmount;
            cn.Open();
            minAmount = Convert.ToInt32(cmd.ExecuteScalar());
            listBox1.Items.Add("最小出貨金額:" + minAmount.ToString("#,##0"));
            cn.Close();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT COUNT(*) FROM Delivery ";
            int DeliveryCount;
            cn.Open();
            DeliveryCount = Convert.ToInt32(cmd.ExecuteScalar());
            listBox1.Items.Add("累計出貨筆數:" + DeliveryCount.ToString("#,##0"));
            cn.Close();
        }
    }
}
