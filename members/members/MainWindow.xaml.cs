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
using System.ComponentModel;

namespace members
{    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
            //new MethodDemo();
            //new DelegateDemo().DoWork();
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _animal.Name = "Lassie (a dog)";
            DataContext = _animal;

            _button.Click += delegate(object s, RoutedEventArgs e2)
            {
                _animal.Name = "Beaker (a cat)";
            };

        }
       
        Animal _animal = new Animal();

        Animal _animal2 = new Animal("Animal2");
    }



    public class Animal : INotifyPropertyChanged
    {
        static Animal()
        {
            _totalAnimalsConstructed = 0;
        }

        public Animal(string name)
        {
            Name = name;
            _totalAnimalsConstructed++;
        }

        public Animal()
            : this("Anonymous")
        {

        }

        static int _totalAnimalsConstructed;


        public string Name
        {
            get { return _name; }

            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }

            }

        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);
                PropertyChanged(this, args);
            }
        }

        private string _name;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
