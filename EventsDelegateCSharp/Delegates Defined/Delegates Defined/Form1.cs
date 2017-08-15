using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates_Defined
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // A delegate type to hold a method that returns a message.
        private delegate string MessageMethod();

        // A method that returns a message.
        private string DayOfWeekMessage()
        {
            return "Today is " + DateTime.Now.DayOfWeek;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make a variable of the delegate type.
            MessageMethod myMethod;

            // Make the variable refer to the message method.
            myMethod = DayOfWeekMessage;

            // Invoke the method.
            myMethod();
        }

        // The array of customers.
        private Customer[] Customers = null;

        // A delegate type for methods that sort customers.
        private delegate void CustomerSorter(Customer[] customers);

        // Make some methods that sort customers.
        private void SortByName(Customer[] customers)
        {
            MessageBox.Show("SortByName");
        }
        private void SortByAccountNumber(Customer[] customers)
        {
            MessageBox.Show("SortByAccountNumber");
        }
        private void SortByBalance(Customer[] customers)
        {
            MessageBox.Show("SortByBalance");
        }


        // Sort by the indicated RadioButton.
        private void sortByRadioButton_Click(object sender, EventArgs e)
        {
            // Create a delegate variable.
            CustomerSorter sorter = null;

            // Make the variable refer to the appropriate method.
            if (sender == nameRadioButton)
                sorter = SortByName;
            else if (sender == accountNumberRadioButton)
                sorter = SortByAccountNumber;
            else
                sorter = SortByBalance;

            // Invoke the method to sort the customers.
            sorter(Customers);
        }
    }
}
