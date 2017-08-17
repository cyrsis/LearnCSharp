using System;
using System.Diagnostics;
using System.Threading;
using System.Windows;

namespace DispatcherExample
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        SlowThing source = new SlowThing();
        public Window1()
        {
            InitializeComponent();
            Debug.WriteLine("UI Thread: " + Thread.CurrentThread.ManagedThreadId);
        }

        private void getDataButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Click Thread: " + Thread.CurrentThread.ManagedThreadId);
            ThreadPool.QueueUserWorkItem(DoSlowWork);
        }

        private void DoSlowWork(object state)
        {
            Debug.WriteLine("Worker Thread: " + Thread.CurrentThread.ManagedThreadId);
            string data = source.Data;

            this.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal,
                new Action<string>(DoUpdateOnUIThread),
                data);
        }

        private void DoUpdateOnUIThread(string data)
        {
            Debug.WriteLine("Update Thread: " + Thread.CurrentThread.ManagedThreadId);
            outputText.Text = data;
        }
    }
}
