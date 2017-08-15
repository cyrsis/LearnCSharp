using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_Targets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate void ShowMessageDelegate();
        ShowMessageDelegate ShowMessage;

        private void Form1_Load(object sender, EventArgs e)
        {
            Person alice = new Person() { Name = "Alice" };
            ShowMessage = alice.ShowName;

            Person bob = new Person() { Name = "Bob" };
            ShowMessage += bob.ShowName;

            ShowMessage += Person.ShowClassName;
            ShowMessage += this.SayHi;

            ShowMessage();
        }

        private void SayHi()
        {
            MessageBox.Show("Hi");
        }
    }
}
