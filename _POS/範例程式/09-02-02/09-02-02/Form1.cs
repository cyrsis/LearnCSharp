using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects;

namespace _09_02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new XINEntities())
            {
                string ESQL = @"SELECT VALUE Customer
                              FROM XINEntities.Customer AS Customer 
                              WHERE Customer.CustomerID = @ID";
                ObjectQuery<Customer> query = new ObjectQuery<Customer>(ESQL, context);
                query.Parameters.Add(new ObjectParameter("ID", "SS"));
                foreach (Customer recs in query)
                {
                    listBox1.Items.Add(recs.CustomerID + "," + recs.CompanyName);
                }
            }
        }
    }
}
