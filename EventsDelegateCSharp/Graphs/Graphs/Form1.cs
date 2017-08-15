using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace Graphs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The method we are currently using.
        private Func<float, float> GraphFunction;

        // Functions we can graph.
        private float Sine(float x)
        {
            return 128 + 50 * (float)Math.Sin(x / 10);
        }
        private float Quadratic(float x)
        {
            x -= 128;
            return 240 - (float)(x * x / 50);
        }

        private Func<float, float> Cubic =
            x =>
            {
                x = (x - 100) / 5;
                float value = x * x * x - 20 * x * x - 10 * x;
                return 100 - value / 20;
            };
            
        //private float Cubic(float x)
        //{
        //    x = (x - 100) / 5;
        //    float value = x * x * x - 20 * x * x - 10 * x;
        //    return 100 - value / 20;
        //}
        private float Logistic(float x)
        {
            x = (x - 128) / 15;
            return 200 - 150 * (float)(1 / (1 + Math.Exp(-x)));
        }

        // Graph the current function.
        private void DrawGraph()
        {
            int width = graphPictureBox.ClientSize.Width;
            int height = graphPictureBox.ClientSize.Height;
            Bitmap bm = new Bitmap(width, height);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                gr.Clear(graphPictureBox.BackColor);

                List<PointF> points = new List<PointF>();
                for (int x = 0; x < width; x++)
                    points.Add(new PointF(x, GraphFunction(x)));
                gr.DrawLines(Pens.Blue, points.ToArray());
            }

            graphPictureBox.Image = bm;
        }

        // Select a function.
        private void sineRadioButton_Click(object sender, EventArgs e)
        {
            GraphFunction = x => 128 + 50 * (float)Math.Sin(x / 10);

            DrawGraph();
        }

        private void quadraticRadioButton_Click(object sender, EventArgs e)
        {
            GraphFunction = x =>
            {
                x -= 128;
                return 240 - (float)(x * x / 50);
            };
            DrawGraph();
        }

        private void cubicRadioButton_Click(object sender, EventArgs e)
        {
            GraphFunction = Cubic;
            DrawGraph();
        }

        private void logisticRadioButton_Click(object sender, EventArgs e)
        {
            GraphFunction = Logistic;
            DrawGraph();
        }
    }
}
