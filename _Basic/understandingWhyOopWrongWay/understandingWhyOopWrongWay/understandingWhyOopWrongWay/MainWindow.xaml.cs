using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<string> lines = new List<string>();
            lines.Add("flashcard;What color is the sky?;blue");
            lines.Add("flashcard;What color is the sun?;yellow");
            lines.Add("multipleChoice;How many stars are in the Big Dipper?;1;5;*7;12");
            lines.Add("trueFalse;The sun sets in the west.;true");
            lines.Add("multipleChoice;How many moons does the earth have?;*1;5;7;12");

            foreach (var line in lines)
            {
                string[] parts = line.Split(';');
                string kind = parts[0];

                TextBlock tbQuestion = new TextBlock();
                string questionText = parts[1];

                switch (kind)
                {
                    case "flashcard":
                        string answerText = parts[2];
                        tbQuestion.Text = questionText;
                        TextBlock tbAnswer = new TextBlock();
                        tbAnswer.Text = answerText;
                        tbAnswer.Visibility = Visibility.Collapsed;
                        StackPanel sp = new StackPanel();

                        tbQuestion.MouseDown += new MouseButtonEventHandler(tbQuestion_MouseDown);

                        sp.Children.Add(tbQuestion);
                        sp.Children.Add(tbAnswer);
                        MainStackPanel.Children.Add(sp);
                        break;
                    case "multipleChoice":
                        tbQuestion.Text = String.Format("MULTIPLE CHOICE: {0}", questionText);
                        MainStackPanel.Children.Add(tbQuestion);
                        break;
                    case "trueFalse":
                        tbQuestion.Text = String.Format("TRUE/FALSE: {0}", questionText);
                        MainStackPanel.Children.Add(tbQuestion);
                        break;
                    default:
                        break;
                }

            }




        }

        void tbQuestion_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //tbAnswer...
        }
    }
}
