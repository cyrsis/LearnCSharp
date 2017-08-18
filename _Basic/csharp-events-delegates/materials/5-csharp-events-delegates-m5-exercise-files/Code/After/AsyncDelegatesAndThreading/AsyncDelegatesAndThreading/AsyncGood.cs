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
        private delegate void ShowProgressDelegate(int val);
        private delegate void StartProcessDelegate(int val);

        public AsyncGood()
        {
            InitializeComponent();
        }

        public static void Main()
        {
            Application.Run(new AsyncGood());
        }

        private void ShowProgress(int i)
        {
            //On helper thread so invoke on UI thread to avoid 
            //updating UI controls from alternate thread			
            if (lblOutput.InvokeRequired == true)
            {
                ShowProgressDelegate del = new ShowProgressDelegate(ShowProgress);
                //this.BeginInvoke executes delegate on thread used by form (UI thread)
                this.BeginInvoke(del, new object[] { i });
            }
            else
            { //On UI thread so we are safe to update
                this.lblOutput.Text = i.ToString();
                this.pbStatus.Value = i;
            }
        }

        private void StartButton_Click(object sender, System.EventArgs e)
        {

            //Call long running process
            StartProcessDelegate startDel = new StartProcessDelegate(StartProcess);
            //startDel.BeginInvoke executes delegate on new thread
            startDel.BeginInvoke(100, null, null);

            //Show message box to demonstrate that StartProcess()
            //is running asynchronously
            MessageBox.Show("Called after async process started.");
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

    }
}
