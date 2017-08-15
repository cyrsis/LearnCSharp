using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Returns a Person.
        delegate Person ReturnsPersonDelegate();
        Person MakePerson() { return new Person(); }
        Employee MakeEmployee() { return new Employee(); }

        // Takes an Employee as a parameter.
        delegate void ProcessEmployeeDelegate(Employee employee);
        void EmailPerson(Person person) { }
        void EmailEmployee(Employee employee) { }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Contravariance. (Parameter types are compatible.)
            ProcessEmployeeDelegate processor;
            processor = EmailEmployee;
            processor(new Employee());

            processor = EmailPerson;
            processor(new Employee());
            // processor(new Person());     // Doesn't work

            // Covariance. (Return types are compatible.)
            ReturnsPersonDelegate returnsPerson;
            returnsPerson = MakePerson;
            Person person = returnsPerson();

            returnsPerson = MakeEmployee;
            person = returnsPerson();
        }
    }
}
