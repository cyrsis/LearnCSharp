using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Students
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student[] students =
            {
                new Student(101, "Beatrice", "Cox"),
                new Student(106, "Debra", "Adams"),
                new Student(105, "Al", "Bailey"),
                new Student(107, "Emilio", "Franklin"),
                new Student(104, "Conrad", "Evans"),
                new Student(103, "Debra", "Adams"),
                new Student(102, "Emilio", "Dean"),
                new Student(108, "Frieda", "Cox"),
            };
            Array.Sort(students);
            foreach (Student student in students)
                listBox1.Items.Add(student.ToString());
        }
    }
}
