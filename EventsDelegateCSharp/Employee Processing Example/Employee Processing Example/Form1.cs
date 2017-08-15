using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Processing_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // A method that processes an employee.
        private delegate void EmployeeProcessor(Employee employee);

        // The employees.
        private List<Employee> Employees = new List<Employee>();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make some employees.
            MakeEmployees();

            // Show the employees.
            ShowEmployees();
        }

        // Add a single employee to the form's ListBox.
        private void ListEmployee(Employee employee)
        {
            employeesListBox.Items.Add(
                employee.Name + ", " +
                employee.Title + ", " +
                employee.Salary.ToString("C"));
        }

        // Do something for all employees.
        private void ProcessEmployees(EmployeeProcessor process)
        {
            foreach (Employee employee in Employees)
                process(employee);
        }

        // Display all employees in the form's ListBox.
        private void ShowEmployees()
        {
            employeesListBox.Items.Clear();
            ProcessEmployees(ListEmployee);
        }

        // Make some employees.
        private void MakeEmployees()
        {
            Employees.Add(new Employee()
            {
                Name = "Alice Archer",
                Title = "Programmer",
                Salary = 60000m,
            });
            Employees.Add(new Employee()
            {
                Name = "Bob Baker",
                Title = "Engineer",
                Salary = 70000m,
            });
            Employees.Add(new Employee()
            {
                Name = "Cindy Carter",
                Title = "Manager",
                Salary = 80000m,
            });
        }

        // Give a single employee a raise.
        private void GiveRaise(Employee employee)
        {
            employee.Salary *= 1.1m;
        }

        // Give all employees a raise.
        private void giveRaisesButton_Click(object sender, EventArgs e)
        {
            ProcessEmployees(GiveRaise);
            ShowEmployees();
        }
    }
}
