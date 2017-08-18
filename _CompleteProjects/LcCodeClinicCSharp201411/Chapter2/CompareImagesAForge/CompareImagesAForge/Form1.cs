using AForge.Imaging;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FileComparerWinForms
{
    public partial class Form1 : Form
    {
        private string largeFileName;
        private string smallFileName;
        private bool img1Selected;
        private bool img2Selected;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            largePicBox.Visible = false;
            smallPicBox.Visible = false;
            btnCompare.Enabled = false;
            ShowStatus("");
        }

        private void LinkLarge_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fileDialog.FileName = "";
            fileDialog.Title = "Select large image";
            fileDialog.Filter = "All images|*.jpg; *.bmp; *.png";
            fileDialog.ShowDialog();
            if (fileDialog.FileName.ToString() != "")
            {
                largeFileName = fileDialog.FileName.ToString();
                largeLink.Text = largeFileName;
                largePicBox.Image = System.Drawing.Image.FromFile(largeFileName);
                largePicBox.Visible = true;
                img1Selected = true;
            }
            ValidateSelections();
        }

        private void LinkSmall_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fileDialog.FileName = "";
            fileDialog.Title = "Select small image";
            fileDialog.Filter = "All images|*.jpg; *.bmp; *.png";
            fileDialog.ShowDialog();
            if (fileDialog.FileName.ToString() != "")
            {
                smallFileName = fileDialog.FileName.ToString();
                smallLink.Text = smallFileName;
                smallPicBox.Image = System.Drawing.Image.FromFile(smallFileName);
                smallPicBox.Visible = true;
                img2Selected = true;
            }
            ValidateSelections();
        }

        private void ValidateSelections()
        {
            ShowStatus("");
            if (img1Selected && img2Selected)
            {
                btnCompare.Enabled = true;
            }
        }

        private void CompareBtn_Click(object sender, EventArgs e)
        {
            ShowStatus("Processing...");

            Bitmap largeImage = (Bitmap)Bitmap.FromFile(largeFileName);
            Bitmap smallImage = (Bitmap)Bitmap.FromFile(smallFileName);

            // create template matching algorithm's instance
            // (set similarity threshold to 90%)
            ExhaustiveTemplateMatching tm = new ExhaustiveTemplateMatching(0.9f);
            
            // find all matchings with specified above similarity
            TemplateMatch[] matches = tm.ProcessImage(largeImage, smallImage);

            if (matches.Length > 0)
            {
                TemplateMatch match = matches[0];
                ShowStatus("Match found at X: " + 
                    match.Rectangle.Location.X + "; Y:" + 
                    match.Rectangle.Location.Y);
            }
            else
            {
                ShowStatus("Match not found");
            }

        }

        private void ShowStatus(string status)
        {
            outputMessage.Text = status;
            outputMessage.Invalidate();
            outputMessage.Update();
            outputMessage.Refresh();
        }

    }
}
