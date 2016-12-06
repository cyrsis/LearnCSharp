using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_02_04
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
                var Product = from P in context.Product
                               select new 
                               { 
                                    ID = P.ProductID, 
                                    Name = P.ProductName 
                               };
                foreach (var recs in Product)
                {
                    listBox1.Items.Add(recs.ID + "," + recs.Name);
                }
            }
        }
    }
}
