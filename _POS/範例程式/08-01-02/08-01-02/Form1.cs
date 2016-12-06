using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_01_02
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
               var Prod = from P in context.Product
                          select new {P.ProductID, P.ProductName, P.Unit, P.Price};
               foreach (var recs in Prod)
                {
                    listBox1.Items.Add(string.Format("{0},{1},{2},{3}", 
                        recs.ProductID, recs.ProductName, recs.Unit, recs.Price));
                }
            }
        }
    }
}
