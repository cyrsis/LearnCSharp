using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICollections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make an array and list of strings.
            string[] array = { "Apple", "Banana", "Cherry", "Date" };
            List<string> list = new List<string>(array);

            DisplayValues(array);
            DisplayValues(list);
        }

        private void DisplayValues(ICollection<string> values)
        {
            string[] reversed = new string[values.Count];
            values.CopyTo(reversed, 0);
            Array.Reverse(reversed);

            Console.WriteLine(values.Count + " items:");
            foreach (string value in reversed)
                Console.WriteLine(value);
        }
    }
}
