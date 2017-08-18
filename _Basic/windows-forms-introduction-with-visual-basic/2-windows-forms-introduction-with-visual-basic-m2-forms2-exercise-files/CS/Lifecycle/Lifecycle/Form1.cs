using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lifecycle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListBox1.Items.Add("Oranges");
            ListBox1.Items.Add("Grapes");
            ListBox1.Items.Add("Bananas");
            ListBox1.Items.Add("Peaches");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = ListBox1.Text;
        }
    }
}
