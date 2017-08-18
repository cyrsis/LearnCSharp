using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwaitableButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await button1;

            button1.Enabled = false;
            button2.Enabled = true;

            await button2;
            await button2;

            MessageBox.Show("Hello!");
        }
    }

    class ButtonAwaiter : INotifyCompletion
    {
        public Button Button { get; set; }

        public bool IsCompleted
        {
            get { return false; }
        }

        public void GetResult()
        {
        }

        public void OnCompleted(Action continuation)
        {
            EventHandler h = null;
            h = (o, e) =>
            {
                Button.Click -= h;
                continuation();
            };

            Button.Click += h;
        }
    }

    static class ButtonExtensions
    {
        public static ButtonAwaiter GetAwaiter(this Button b)
        {
            return new ButtonAwaiter { Button = b };
        }
    }
}
