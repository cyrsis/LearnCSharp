using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FileComparerWinForms
{
    public partial class Form1 : Form
    {
        //This is the threshold for successful comparison
        const double THRESHOLD = .9;
        
        //Some field declarations
        private string largeFileName="";
        private string smallFileName="";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar.Visible = false;
            largePicBox.Visible = false;
            smallPicBox.Visible = false;
            btnCompare.Enabled = false;
            outputMessage.Text = "";
        }

        private void LinkLarge_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fileDialog.FileName = "";
            fileDialog.Title = "Select main image";
            fileDialog.Filter = "All images|*.jpg; *.bmp; *.png";
            fileDialog.ShowDialog();
            if (fileDialog.FileName.ToString() != "")
            {
                largeFileName = fileDialog.FileName.ToString();
                largeLabel.Text = largeFileName;
                largePicBox.Image = Image.FromFile(largeFileName);
                largePicBox.Visible = true;
            }
            ValidateSelections();
        }

        private void LinkSmall_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fileDialog.FileName = "";
            fileDialog.Title = "Select sub image";
            fileDialog.Filter = "All images|*.jpg; *.bmp; *.png";
            fileDialog.ShowDialog();
            if (fileDialog.FileName.ToString() != "")
            {
                smallFileName = fileDialog.FileName.ToString();
                smallLabel.Text = smallFileName;
                smallPicBox.Image = Image.FromFile(smallFileName);
                smallPicBox.Visible = true;
            }
            ValidateSelections();
        }

        private void ValidateSelections()
        {
            if (largeFileName.Length > 0 && smallFileName.Length > 0)
            {
                btnCompare.Enabled = true;
            }
        }

        private void CompareBtn_Click(object sender, EventArgs e)
        {
            //Get images as bitmaps
            Bitmap largeBitMap = new Bitmap(largeFileName);
            Bitmap smallBitmap = new Bitmap(smallFileName);
            
            //Initialize progress bar
            progressBar.Minimum = 0;
            progressBar.Maximum = largeBitMap.Height + smallBitmap.Height;
            progressBar.Value = 0;
            progressBar.Visible = true;

            //Transform bitmaps to lists of strings, one string for each row of pixels
            List<string> rowsMain = GetRows(largeBitMap);
            List<string> rowsSub = GetRows(smallBitmap);

            //Process the results
            string msg;
            if (IsSubset(rowsMain, rowsSub))
            {
                msg = "Small image is a subset of the large image";
            }
            else
            {
                msg = "Small image isn't a subset of the large image";
            }

            //Show the results
            progressBar.Visible = false;
            outputMessage.Visible = true;
            outputMessage.Text = msg;

        }

        private List<string> GetRows(Bitmap bitMap)
        {
            List<string> rows = new List<string>();
            StringBuilder sb = new StringBuilder();
            for (int y = 0; y < bitMap.Height; y++)
            {
                sb.Clear();
                for (int x = 0; x < bitMap.Width; x++)
                {
                    int hash = bitMap.GetPixel(x, y).GetHashCode();
                    sb.Append(hash);
                }
                rows.Add(sb.ToString());
                progressBar.Value++;
            }
            return rows;
        }

        private bool IsSubset(List<string> rowsLarge, List<string> rowsSmall)
        {
            //Loop through rows of pixels in 1 image, see if each row is part of the other image
            //If any rows fail, there's no match
            int matches = 0;
            int misses = 0;
            foreach (string rowSmall in rowsSmall)
            {
                bool match = false;
                foreach (string rowLarge in rowsLarge)
                {
                    if (rowLarge.Contains(rowSmall))
                    {
                        match = true;
                        break;
                    }
                }
                if (match)
                    matches++;
                else
                    misses++;
            }
            
            //Calculate percentage of matchine lines
            double percentMatches = ((double)matches / (double)(matches + misses));
            Debug.WriteLine("Matches: " + matches + ", Misses: " + misses);
            Debug.WriteLine("Percent matches = " + (percentMatches * 100) + "%");
            
            //Return bool based on matching threshold of success
            return (percentMatches >= THRESHOLD);

        }

    }
}
