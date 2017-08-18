using Microsoft.WindowsAPICodePack.Dialogs;
using SE.Halligang.CsXmpToolkit.Schemas;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace ImageInfo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string imageDir;
        private Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

        public MainWindow()
        {
            InitializeComponent();

            //Initialize output
            txtOutput.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Ask the user which directory to scan
            //Depends on Windows API Code Pack
            CommonOpenFileDialog dlg = new CommonOpenFileDialog();
            dlg.Title = "Select a directory with images";
            dlg.IsFolderPicker = true;
            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                data.Clear();
                imageDir = dlg.FileName;

                // Analyze the image files
                AnalyzeImages();

                //Display the results
                DisplayResults();
            }

        }

        //Get the data
        private void AnalyzeImages()
        {
            //Get a list of files in the selected folder
            IEnumerable files = Directory.EnumerateFiles(imageDir, "*", SearchOption.AllDirectories);

            //Iterate through list of files
            foreach (string imageFile in files)
            {
                FileInfo info = new FileInfo(imageFile);

                //If any file extension other than jpg or png, skip the file
                if (!info.Extension.Equals(".jpg") && 
                    !info.Extension.Equals(".png"))
                {
                    continue;
                }

                //For each file, open a stream and get info about the file
                using (FileStream stream = new FileStream(info.FullName, FileMode.Open, FileAccess.Read, FileShare.Read))
                {

                    string title = "";
                    BitmapSource img = BitmapFrame.Create(stream);
                    BitmapMetadata md = (BitmapMetadata)img.Metadata;

                    //Handle jpg and png files differently
                    switch (md.Format)
                    {
                        //JPG files have Exif info embedded, and it's available through the metadata
                        case "jpg":
                            title = md.Title;
                            break;

                        //For PNG files, use the CSXmpToolkit project
                        case "png":
                            using (Xmp xmp = Xmp.FromFile(imageFile, XmpFileMode.ReadOnly))
                            {
                                DublinCore dc = new DublinCore(xmp);
                                title = dc.Title.DefaultValue;
                            }
                            break;
                    }

                    //Add to dictionary, with one ArrayList per initial character
                    //Each ArrayList can contain multiple titles
                    string firstChar = title.Substring(0, 1).ToUpper();
                    if (!data.ContainsKey(firstChar))
                    {
                        data.Add(firstChar, new List<string>());
                    }
                    data[firstChar].Add(title);
                }
            }
        }

        //Display the results
        private void DisplayResults()
        {

            //Get a list of key values (single characters), sorted alphabetically
            List<string> keys = new List<string>(data.Keys);
            keys.Sort();

            //Display the directory name
            txtOutput.Text = "Images in: " + imageDir + "\n\n";

            //For each key, display the key, and then its members, also sorted
            foreach (string key in keys)
            {
                txtOutput.Text += key + "\n";

                List<string> titles = data[key];
                titles.Sort();
                foreach (string title in titles)
                {
                    txtOutput.Text += " \u2022 " + title + "\n";
                }
                txtOutput.Text += "\n";
            }
        }

    }
}
