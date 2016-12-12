using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_IEnumerable___Part_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Display squares up to 10,000.
        private void Form1_Load(object sender, EventArgs e)
        {
            SquaresGenerator generator = new SquaresGenerator();
            foreach (long value in generator)
            {
                if (value > 10000) break;
                squaresListBox.Items.Add(value);
            }
        }
    }
}
