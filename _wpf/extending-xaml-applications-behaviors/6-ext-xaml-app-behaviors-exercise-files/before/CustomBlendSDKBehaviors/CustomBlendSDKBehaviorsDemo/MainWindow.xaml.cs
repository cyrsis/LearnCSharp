using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomBlendSDKBehaviorsDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Persons = new ObservableCollection<Person>
            {
                new Customer { Id = 1, Name="Always Right", LastOrderDate = DateTime.Parse("05/01/2014"), Phone="1234567890" },
                new Employee { Id = 1, Name="Homer", Phone="0987654321", Boss = "Mr Burns" },
                new Employee { Id = 1, Name="Lisa", Phone="0987654321", Boss = "Homer" },
                new Customer { Id = 1, Name="Mostly Right", LastOrderDate = DateTime.Parse("05/01/2014"), Phone="1234567890" },
                new Employee { Id = 1, Name="Bart", Phone="0987654321", Boss = "Homer" },

            };
        }

        public ObservableCollection<Person> Persons
        {
            get { return (ObservableCollection<Person>)GetValue(PersonsProperty); }
            set { SetValue(PersonsProperty, value); }
        }

        public static readonly DependencyProperty PersonsProperty =
            DependencyProperty.Register("Persons", typeof(ObservableCollection<Person>), 
            typeof(MainWindow), new PropertyMetadata(null));


    }
}
