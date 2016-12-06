using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_05_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //建立DataContext類別的物件
            var context = new XINEntities();
            //建立查詢語言
            var query = from M in context.Delivery
                        group M by M.CustomerID into cust
                        orderby cust.Key
                        select cust;
            foreach (var recs in query)
            {
                listBox1.Items.Add(recs.Key);
            }
        }
    }
}
