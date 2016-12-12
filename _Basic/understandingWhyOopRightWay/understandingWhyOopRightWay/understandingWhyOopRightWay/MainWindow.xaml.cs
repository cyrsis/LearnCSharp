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
                Question question = Question.Create(line);
                MainStackPanel.Children.Add(question.RenderControl());

            }

        }
    }


    public class Question
    {
        protected string[] _parts;
        private string _line;
        protected string _questionText;

        public Question(string line)
        {
            _line = line;

            _parts = line.Split(';');
            _questionText = _parts[1];

        }

        public static Question Create(string line)
        {
            if (line.StartsWith("flashcard;"))
                return new Flashcard(line);
            else if (line.StartsWith("multipleChoice;"))
                return new MultipleChoice(line);
            else if (line.StartsWith("trueFalse;"))
                return new TrueFalse(line);
            else
                return new Question(line);
        }


        internal virtual UIElement RenderControl()
        {
            TextBlock tb = new TextBlock();
            tb.Text = "Bad syntax in line: " + _line;
            return tb;
        }


        protected UIElement AdornStackPanel(StackPanel sp)
        {
            sp.Margin = new Thickness(5);
            return sp;
        }


    }

    public class Flashcard : Question
    {
        private string _answerText;
        private TextBlock _tbAnswer;
        private bool _answerIsVisible = false;

        public Flashcard(string line) : base(line)
        {
            _answerText = _parts[2];
        }

        internal override UIElement RenderControl()
        {
            StackPanel sp = new StackPanel();
            TextBlock tbQuestion = new TextBlock();
            tbQuestion.Text = _questionText;
            tbQuestion.Cursor = Cursors.Hand;
            _tbAnswer = new TextBlock();
            _tbAnswer.Text = _answerText;

            tbQuestion.MouseDown += new MouseButtonEventHandler(tbQuestion_MouseDown);

            _tbAnswer.Visibility = Visibility.Collapsed;

            sp.Children.Add(tbQuestion);
            sp.Children.Add(_tbAnswer);

            return AdornStackPanel(sp);
        }

        void tbQuestion_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (_answerIsVisible)
                _tbAnswer.Visibility = Visibility.Collapsed;
            else
                _tbAnswer.Visibility = Visibility.Visible;
            _answerIsVisible = !_answerIsVisible;
        }

    }

    public class MultipleChoice : Question
    {
        private string _answer1Text;
        private string _answer2Text;
        private string _answer3Text;
        private string _answer4Text;

        public MultipleChoice(string line) : base(line)
        {
            _answer1Text = _parts[2];
            _answer2Text = _parts[3];
            _answer3Text = _parts[4];
            _answer4Text = _parts[5];
        }

        internal override UIElement RenderControl()
        {
            StackPanel sp = new StackPanel();
            TextBlock tbQuestion = new TextBlock();
            tbQuestion.Text = _questionText;

            TextBlock _tbAnswer1 = new TextBlock();
            _tbAnswer1.Text = _answer1Text;

            TextBlock _tbAnswer2 = new TextBlock();
            _tbAnswer2.Text = _answer2Text;

            TextBlock _tbAnswer3 = new TextBlock();
            _tbAnswer3.Text = _answer3Text;

            TextBlock _tbAnswer4 = new TextBlock();
            _tbAnswer4.Text = _answer4Text;


            sp.Children.Add(tbQuestion);
            sp.Children.Add(_tbAnswer1);
            sp.Children.Add(_tbAnswer2);
            sp.Children.Add(_tbAnswer3);
            sp.Children.Add(_tbAnswer4);

            return AdornStackPanel(sp);
        }
    }

    public class TrueFalse : Flashcard
    {
        public TrueFalse(string line) : base(line)
        {
            _questionText = "TRUE or FALSE: " + _questionText;
        }

    }


}
