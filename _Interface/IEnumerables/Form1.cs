using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEnumerables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make an array of people.
            Person[] personArray =
            {
                new Person("Ann", "Archer"),
                new Person("Bob", "Baker"),
                new Person("Cindy", "Carter"),
                new Person("Dan", "Dent"),
            };

            // Make a list of people.
            List<Person> personList =
                new List<Person>(personArray);

            // Display the array.
            ShowEnumerable(listBox1, personArray);

            // Display the list.
            ShowEnumerable(listBox2, personList);
        }

        private void ShowArray(ListBox lst, Person[] people)
        {
            lst.Items.Clear();
            foreach (Person person in people)
                lst.Items.Add(person.ToString());
        }

        private void ShowList(ListBox lst, List<Person> people)
        {
            lst.Items.Clear();
            foreach (Person person in people)
                lst.Items.Add(person.ToString());
        }

        private void ShowEnumerable(ListBox lst, IEnumerable<Person> people)
        {
            lst.Items.Clear();
            foreach (Person person in people)
                lst.Items.Add(person.ToString());
        }
    }
}
