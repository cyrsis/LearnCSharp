using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person p = new Person { 
                FirstName = "Rob", 
                LastName = "Windsor", 
                Age = 49 
            };

            personControl1.Person = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personControl1.Person.LastName, this.Text);
        }
    }
}
