using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.Objects;

namespace _09_11_06
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
                ObjectQuery<DbDataRecord> query =
                    context.Product.Select("it.ProductID, it.ProductName")
                                   .OrderBy("it.ProductName")
                                   .Top("@limit", new ObjectParameter("limit", 6));
                dataGridView1.DataSource = query;
                dataGridView1.Columns[0].HeaderText = "商品編號";
                dataGridView1.Columns[1].HeaderText = "商品名稱";
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].Width = 450;
            }
        }
    }
}
