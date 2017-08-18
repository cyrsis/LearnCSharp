using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonRepository.Fake
{
    public class FakeRepository : IPersonRepository
    {
        public IEnumerable<Person> GetPeople()
        {
            var people = new List<Person>()
            {
                new Person() {FirstName = "John", LastName = "Smith", 
                    Rating = 7, StartDate = new DateTime(2000, 10, 1)},
                new Person() {FirstName = "Mary", LastName = "Thomas", 
                    Rating = 9, StartDate = new DateTime(1971, 7, 23)},
            };
            return people;

        }

        public Person GetPerson(string lastName)
        {
            throw new NotImplementedException();
        }

        public void AddPerson(Person newPerson)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(string lastName, Person updatedPerson)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(string lastName)
        {
            throw new NotImplementedException();
        }

        public void UpdatePeople(IEnumerable<Person> updatedPeople)
        {
            throw new NotImplementedException();
        }
    }
}
