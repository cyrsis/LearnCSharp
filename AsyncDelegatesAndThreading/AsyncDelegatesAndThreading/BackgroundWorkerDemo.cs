using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadsAndDelegates
{
    public partial class BackgroundWorkerDemo : Form
    {
        public BackgroundWorkerDemo()
        {
            InitializeComponent();
        }

        public static void Main()
        {
            Application.Run(new BackgroundWorkerDemo());
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            CancelButton.Enabled = true;
            OutputLabel.Text = "";
            MyBackgroundWorker.RunWorkerAsync();
        }

        private void MyBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // This method will run on a thread other than the UI thread.
            // Be sure not to manipulate any Windows Forms controls created
            // on the UI thread from this method.
            e.Result = this.Calculate(sender as BackgroundWorker, e);
        }

        private long Calculate(BackgroundWorker instance, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                if (instance.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(100);
                    instance.ReportProgress(i);
                }
            }
            return 0L;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MyBackgroundWorker.CancelAsync();
            CancelButton.Enabled = false;
        }

        private void MyBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Data marshalled back to UI thread so it is safe to update the progress bar here
            progressBar1.Value = e.ProgressPercentage;
        }

        private void MyBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            StartButton.Enabled = true;
            progressBar1.Value = 0;
            if (!e.Cancelled)
            {
                OutputLabel.Text = "BackgroundWorker Completed!";
            }
            else
            {
                OutputLabel.Text = "Cancelled!";
            }
        }
    }
}
