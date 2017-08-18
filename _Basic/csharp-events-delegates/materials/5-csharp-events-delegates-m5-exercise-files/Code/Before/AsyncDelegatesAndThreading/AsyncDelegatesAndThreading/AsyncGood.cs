using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadsAndDelegates
{
    public partial class AsyncGood : Form
    {
        delegate void UpdateProgressDelegate(int val);

        public AsyncGood()
        {
            InitializeComponent();
        }

        public static void Main()
        {
            Application.Run(new AsyncGood());
        }

        private void StartButton_Click(object sender, System.EventArgs e)
        {
            UpdateProgressDelegate progDel = new UpdateProgressDelegate(StartProcess);
            progDel.BeginInvoke(100, null, null);
            MessageBox.Show("Done with operation!!");

        }

        //Called Asynchronously
        private void StartProcess(int max)
        {
            ShowProgress(0);
            for (int i = 0; i <= max; i++)
            {
                Thread.Sleep(10);
                ShowProgress(i);
            }
        }

        private void ShowProgress(int i)
        {

        }

    }
}
