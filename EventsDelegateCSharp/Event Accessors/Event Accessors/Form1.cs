using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Accessors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SingleWatcher Watcher = new SingleWatcher();

        private void Form1_Load(object sender, EventArgs e)
        {
            Watcher.SingleEvent += Watcher_SingleEvent;
            Watcher.SingleEvent += Watcher_SingleEvent;
            Watcher.SingleEvent += Watcher_SingleEvent;
        }

        private void Watcher_SingleEvent(object sender, EventArgs e)
        {
            MessageBox.Show("SingleEvent");
        }

        private void raiseEventButton_Click(object sender, EventArgs e)
        {
            Watcher.OnSingleEvent();
        }
    }
}
