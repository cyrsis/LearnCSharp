using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_03_01
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
            DataTable dtProduct = new DataTable();
            DataTable dtCustomer = new DataTable();
            DataTable dtDelivery = new DataTable();
            DataTable dtDeliveryDetails = new DataTable();
            dsXIN.Tables.Add(dtProduct);
            dsXIN.Tables.Add(dtCustomer);
            dsXIN.Tables.Add(dtDelivery);
            dsXIN.Tables.Add(dtDeliveryDetails);
            listBox1.Items.Clear();
            int i;
            for (i = 0; i <= dsXIN.Tables.Count - 1; i++)
            {
                listBox1.Items.Add(dsXIN.Tables[i].TableName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet dsXIN = new DataSet("XIN");
            DataTable dtProduct = new DataTable("Product");
            DataTable dtCustomer = new DataTable("Customer");
            DataTable dtDelivery = new DataTable("Delivery");
            DataTable dtDeliveryDetails = new DataTable("DeliveryDetails");
            dsXIN.Tables.Add(dtProduct);
            dsXIN.Tables.Add(dtCustomer);
            dsXIN.Tables.Add(dtDelivery);
            dsXIN.Tables.Add(dtDeliveryDetails);
            listBox1.Items.Clear();
            int i;
            for (i = 0; i <= dsXIN.Tables.Count - 1; i++)
            {
                listBox1.Items.Add(dsXIN.Tables[i].TableName);
            }
        }
    }
}
