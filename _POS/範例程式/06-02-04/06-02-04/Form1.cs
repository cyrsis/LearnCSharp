using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_02_04
{
    public partial class Form1 : Form
    {

        DataTable dtSupplier = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtSupplier = dsXIN1.Tables["Supplier"];
            btnFill_Click(sender, e);
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(dsXIN1, "Supplier");
        }

        //Update(DataSet)
        private void btnDataSet_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(dsXIN1);
        }

        //Update(DataTable)
        private void btnDataTable_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(dtSupplier);
        }

        //Update(DataSet, Table Name)
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(dsXIN1, "Supplier");
        }
    }
}
