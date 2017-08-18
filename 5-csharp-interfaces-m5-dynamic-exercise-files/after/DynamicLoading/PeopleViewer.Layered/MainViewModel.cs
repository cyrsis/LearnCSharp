using PersonRepository.Interface;
using System.Collections.Generic;
using System.ComponentModel;

namespace PeopleViewer
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private IPersonRepository repository;

        private IEnumerable<Person> people;
        public IEnumerable<Person> People
        {
            get { return people; }
            set
            {
                people = value;
                RaisePropertyChanged("People");
            }
        }

        public string RepositoryType
        {
            get { return repository.GetType().ToString(); }
        }

        public MainViewModel()
        {
            repository = RepositoryFactory.GetRepository();
        }

        public void FetchData()
        {
            People = repository.GetPeople();
        }

        public void ClearData()
        {
            People = new List<Person>();
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
