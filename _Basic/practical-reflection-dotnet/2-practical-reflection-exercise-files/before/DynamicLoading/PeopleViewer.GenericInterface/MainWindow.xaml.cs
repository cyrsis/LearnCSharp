using Factory.RepositoryFactory;
using GenericRepository.Interface;
using PeopleViewer.SharedObjects;
using System.Windows;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        IRepository<Person, string> repository;

        public MainWindow()
        {
            InitializeComponent();
            repository = GenericFactory.Get<IRepository<Person, string>>();
        }

        private void FetchButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();

            var people = repository.GetItems();
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

        private void ShowRepositoryType(IRepository<Person, string> repository)
        {
            RepositoryTypeBlock.Text = repository.GetType().ToString();
        }
    }
}
