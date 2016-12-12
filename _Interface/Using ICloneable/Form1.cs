using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_ICloneable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Address address = new Address(
                "100 Ash Av", "Programmeria", "HI", "98765");
            Person alice = new Person("Alice", "Archer", address);

            Person bob = (Person)alice.Clone(true);
            bob.FirstName = "Bob";
            bob.MailingAddress.Street = "2000 Beach Bl";
        }
    }
}
