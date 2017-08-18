using PeopleViewer.SharedObjects;
using GenericRepository.Interface;
using GenericRepository.Service.MyService;
using System.Collections.Generic;
using System.Linq;

namespace GenericRepository.Service
{
    public class PersonRepository : IRepository<Person, string>
    {
        private IPersonService _serviceProxy;
        public IPersonService ServiceProxy
        {
            get
            {
                if (_serviceProxy == null)
                    _serviceProxy = new PersonServiceClient();
                return _serviceProxy;
            }
            set
            {
                if (_serviceProxy == value)
                    return;
                _serviceProxy = value;
            }
        }

        public IEnumerable<Person> GetItems()
        {
            return ServiceProxy.GetPeople();
        }

        public Person GetItem(string lastName)
        {
            return ServiceProxy.GetPerson(lastName);
        }

        public void AddItem(Person newPerson)
        {
            ServiceProxy.AddPerson(newPerson);
        }

        public void UpdateItem(string lastName, Person updatedPerson)
        {
            ServiceProxy.UpdatePerson(lastName, updatedPerson);
        }

        public void DeleteItem(string lastName)
        {
            ServiceProxy.DeletePerson(lastName);
        }

        public void UpdateItems(IEnumerable<Person> updatedPeople)
        {
            ServiceProxy.UpdatePeople(updatedPeople.ToList());
        }
    }
}
