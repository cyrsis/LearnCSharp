using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindNextToMin
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

            Console.WriteLine(FindNextToMin(ints));
            Console.WriteLine(FindNextToMin(strings));
        }

        private T FindNextToMin<T>(IEnumerable<T> values) where T : IComparable<T>
        {
            T min1 = default(T);    // The smallest.
            T min2 = default(T);    // The second smallest.
            int numProcessed = 0;
            foreach (T value in values)
            {
                // If it's the first value, just put it in min2.
                if (numProcessed == 0) min2 = value;
                else if (numProcessed == 1)
                {
                    // It's the second value.
                    // If it's smaller than min2, it goes in min1.
                    if (value.CompareTo(min2) < 0) min1 = value;
                    else
                    {
                        // Otherwise the new value belongs in min2.
                        min1 = min2;
                        min2 = value;
                    }
                }
                else
                {
                    if (value.CompareTo(min1) < 0)
                    {
                        // The new value is smaller than min1.
                        // Move min1 --> min2 and save the new value in min1.
                        min2 = min1;
                        min1 = value;
                    }
                    else if (value.CompareTo(min2) < 0)
                    {
                        // The new value is between min1 and min2.
                        // Save the new value in min2.
                        min2 = value;
                    }
                }

                // Increment the number processed.
                numProcessed++;
            }
            return min2;
        }
    }
}
