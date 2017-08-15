using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE_Event_Handlers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            submitButton.Enabled = (
                (firstNameTextBox.Text.Length > 0) &&
                (lastNameTextBox.Text.Length > 0) &&
                (streetTextBox.Text.Length > 0) &&
                (cityTextBox.Text.Length > 0) &&
                (stateTextBox.Text.Length > 0) &&
                (zipTextBox.Text.Length > 0));
        }
    }
}
