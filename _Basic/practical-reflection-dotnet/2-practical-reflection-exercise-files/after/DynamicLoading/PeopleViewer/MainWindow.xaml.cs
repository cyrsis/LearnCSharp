using Factory.RepositoryFactory;
using PersonRepository.Interface;
using System.Windows;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        IPersonRepository repository;

        public MainWindow()
        {
            InitializeComponent();
            //repository = RepositoryFactory.GetPersonRepository();
            repository = GenericFactory.Get<IPersonRepository>();
        }

        private void FetchButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();

            var people = repository.GetPeople();
            foreach (var person in people)
                PersonListBox.Items.Add(person);

            ShowRepositoryType(repository);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            PersonListBox.Items.Clear();
            RepositoryTypeBlock.Text = string.Empty;
        }

        private void ShowRepositoryType(IPersonRepository repository)
        {
            RepositoryTypeBlock.Text = repository.GetType().ToString();
        }
    }
}
