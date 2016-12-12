using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumerate_Students
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make the array.
            Student[] studentArray =
            {
                new Student("1000", "Art", "Ainsley"),
                new Student("2000", "Bea", "Best"),
                new Student("3000", "Chuck", "Camp"),
                new Student("4000", "Dena", "Dell"),
            };

            // Make the list.
            List<Student> studentList =
                new List<Student>(studentArray);

            // Make the dictionary.
            Dictionary<string, Student> studentDict =
                new Dictionary<string, Student>();
            foreach (Student student in studentArray)
                studentDict.Add(student.StudentId, student);

            // Display the array.
            ShowEnumerable(listBox1, studentArray);

            // Display the list.
            ShowEnumerable(listBox2, studentList);

            // Display the dictionary's values.
            ShowEnumerable(listBox3, studentDict.Values);
        }

        // Display an IEnumerable of Student.
        private void ShowEnumerable(ListBox lst,
            IEnumerable<Student> students)
        {
            lst.Items.Clear();
            foreach (Student student in students)
                lst.Items.Add(student.ToString());
        }
    }
}
