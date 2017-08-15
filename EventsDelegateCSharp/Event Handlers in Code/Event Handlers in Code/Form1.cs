using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Handlers_in_Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clickMeButton.Click += new EventHandler(ClickMeButton_Click);
            clickMeButton.Click += ClickMeButton_Click;

            this.ResizeEnd += Form1_ResizeEnd;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            MessageBox.Show("ResizeEnd");
            this.ResizeEnd -= Form1_ResizeEnd;
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("FormClosing");
        }

        private void ClickMeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
            clickMeButton.Click -= ClickMeButton_Click;
            clickMeButton.Click -= ClickMeButton_Click;
        }
    }
}
