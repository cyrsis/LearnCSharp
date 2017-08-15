using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_Variance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Person MakePerson() { return new Person(); }
        Employee MakeEmployee() { return new Employee(); }

        void EmailPerson(Person person) { }
        void EmailEmployee(Employee employee) { }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Contravariance.
            Action<Person>[] personProcessors = new Action<Person>[10];
            personProcessors[0] = EmailPerson;
            //personProcessors[1] = EmailEmployee;  // Doesn't work.

            Action<Employee>[] employeeProcessors = new Action<Employee>[10];
            employeeProcessors[0] = EmailEmployee;
            employeeProcessors[1] = EmailPerson;

            employeeProcessors = personProcessors;
            //personProcessors = employeeProcessors; // Doesn't work.

            // Covariance.
            Func<Person>[] personMakers = new Func<Person>[10];
            personMakers[0] = MakePerson;
            personMakers[1] = MakeEmployee;

            Func<Employee>[] employeeMakers = new Func<Employee>[10];
            employeeMakers[0] = MakeEmployee;
            //employeeMakers[1] = MakePerson;      // Doesn't work.

            personMakers = employeeMakers;
            //employeeMakers = personMakers;       // Doesn't work.
            //Employee employee = personMakers[0](); // Doesn't work.
        }
    }
}
