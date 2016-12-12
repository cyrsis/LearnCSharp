using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] ints = { 92, 381, 17, 288 };

            List<string> strings = new List<string>();
            strings.Add("Mercury");
            strings.Add("Venus");
            strings.Add("Earth");
            strings.Add("Mars");

            Console.WriteLine(FindMin(ints));
            Console.WriteLine(FindMin(strings));
        }

        private T FindMin<T>(IEnumerable<T> values) where T : IComparable<T>
        {
            T min = default(T);
            bool firstTime = true;
            foreach (T value in values)
            {
                if (firstTime)
                {
                    firstTime = false;
                    min = value;
                }
                else
                    if (min.CompareTo(value) > 0) min = value;
            }
            return min;
        }
    }
}
