using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priority_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The software project we're managing.
        private SoftwareProject TheProject;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create the project.
            TheProject = new SoftwareProject()
            { Name = "Priority Events", Status = ReviewStatus.Pending };

            // Add some event handlers in mixed up order.
            TheProject.AddReviewHandler(7, TheProject_ReviewEventHandler);
            TheProject.AddReviewHandler(3, TheProject_ReviewEventHandler);
            TheProject.AddReviewHandler(5, TheProject_ReviewEventHandler);
        }

        // The event handler.
        private void TheProject_ReviewEventHandler(
            SoftwareProject project, ReviewEventArgs args)
        {
            string message = "Priority " + args.Priority.ToString() +
                "\n\nYes to Approve\nNo to Reject\nCancel for Pending";
            switch (MessageBox.Show(message, "Review",
                MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes:
                    args.Project.Status = ReviewStatus.Approved;
                    break;
                case DialogResult.No:
                    args.Project.Status = ReviewStatus.Rejected;
                    break;
            }
        }

        // Review the project.
        private void reviewButton_Click(object sender, EventArgs e)
        {
            // Raise the event.
            TheProject.OnReviewEvent();

            // Update the project's status.
            statusLabel.Text = TheProject.Status.ToString();
        }

        // Reset the project's status.
        private void resetButton_Click(object sender, EventArgs e)
        {
            TheProject.Status = ReviewStatus.Pending;
            statusLabel.Text = TheProject.Status.ToString();
        }
    }
}
