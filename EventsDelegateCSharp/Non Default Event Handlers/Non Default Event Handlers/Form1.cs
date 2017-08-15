using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Non_Default_Event_Handlers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clickMeButton_MouseEnter(object sender, EventArgs e)
        {
            clickMeButton.Size = new Size(180, 75);
        }

        private void clickMeButton_MouseLeave(object sender, EventArgs e)
        {
            clickMeButton.Size = new Size(120, 50);
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void redRadioButton_Click(object sender, EventArgs e)
        {
            if (redRadioButton.Checked) this.ForeColor = Color.Red;
            if (greenRadioButton.Checked) this.ForeColor = Color.Green;
            if (blueRadioButton.Checked) this.ForeColor = Color.Blue;
        }

        private void circlePictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(Pens.Blue, 10, 10, 50, 50);

            // Draw the points clicked.
            foreach (Point point in Points)
                e.Graphics.DrawEllipse(Pens.Red,
                    point.X - 5, point.Y - 5, 10, 10);
        }

        // Points clicked.
        private List<Point> Points = new List<Point>();

        private void circlePictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            // Save the new point clicked.
            Points.Add(e.Location);

            // Redraw.
            circlePictureBox.Refresh();
        }
    }
}
