using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMedian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] ints = { 92, 28, 17, 35, 46 };

            List<string> strings = new List<string>();
            strings.Add("Spinach");
            strings.Add("Artichoke");
            strings.Add("Beans");
            strings.Add("Squash");
            strings.Add("Broccoli");

            listBox1.Items.Add(ints.FindMedian());
            listBox1.Items.Add(strings.FindMedian());

        }
    }
}
