using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_Arithmetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Some simple methods.
        private void A()
        {
            resultsListBox.Items.Add("A");
        }
        private void B()
        {
            resultsListBox.Items.Add("B");
        }
        private void C()
        {
            resultsListBox.Items.Add("C");
        }

        // Delegate variables.
        private Action Del1, Del2, Del3;

        // Initialize the delegate variables.
        private void Form1_Load(object sender, EventArgs e)
        {
            Del1 = (Action)A + B + A + B;
            Del2 = (Action)A + B + C;
            Del3 = (Action)A + B;
        }

        // Make the variable display its member methods.
        private void ShowDelegate(Action variable)
        {
            resultsListBox.Items.Clear();
            variable();
        }

        private void del1Button_Click(object sender, EventArgs e)
        {
            ShowDelegate(Del1);
        }

        private void del2Button_Click(object sender, EventArgs e)
        {
            ShowDelegate(Del2);
        }

        private void del3Button_Click(object sender, EventArgs e)
        {
            ShowDelegate(Del3);
        }

        private void del1PlusDel2Button_Click(object sender, EventArgs e)
        {
            ShowDelegate(Del1 + Del2);
        }

        private void del1MinusBButton_Click(object sender, EventArgs e)
        {
            ShowDelegate(Del1 - B);
        }

        private void del1MinusDel2Button_Click(object sender, EventArgs e)
        {
            ShowDelegate(Del1 - Del2);
        }

        private void del1MinusDel3Button_Click(object sender, EventArgs e)
        {
            ShowDelegate(Del1 - Del3);
        }
    }
}
