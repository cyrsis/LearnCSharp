using PeopleViewer.SharedObjects;
using GenericRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericRepository.SQL
{
    public class PersonRepository : IRepository<Person, string>
    {
        public IEnumerable<Person> GetItems()
        {
            using (var ctx = new PeopleEntities())
            {
                var people = from p in ctx.DataPersons
                             select new Person
                             {
                                 FirstName = p.FirstName,
                                 LastName = p.LastName,
                                 StartDate = p.StartDate.Value,
                                 Rating = p.Rating.Value,
                             };

                return people.ToList();
            }
        }

        public Person GetItem(string lastName)
        {
            Person person = null;

            using (var context = new PeopleEntities())
            {
                var foundPerson = GetDataPerson(context, lastName);
                if (foundPerson != null)
                    person = GetPersonFromDataPerson(foundPerson);
            }
            return person;
        }

        public void AddItem(Person newPerson)
        {
            using (var context = new PeopleEntities())
            {
                if (GetDataPerson(context, newPerson.LastName) != null)
                    return;

                var person = new DataPerson()
                {
                    FirstName = newPerson.FirstName,
                    LastName = newPerson.LastName,
                    StartDate = newPerson.StartDate,
                    Rating = newPerson.Rating,
                };
                context.DataPersons.Add(person);
                context.SaveChanges();
            }
        }

        public void UpdateItem(string lastName, Person updatedPerson)
        {
            using (var context = new PeopleEntities())
            {
                var foundPerson = GetDataPerson(context, lastName);
                if (foundPerson == null)
                    return;

                foundPerson.FirstName = updatedPerson.FirstName;
                foundPerson.LastName = updatedPerson.LastName;
                foundPerson.StartDate = updatedPerson.StartDate;
                foundPerson.Rating = updatedPerson.Rating;

                context.SaveChanges();
            }
        }

        public void DeleteItem(string lastName)
        {
            using (var context = new PeopleEntities())
            {
                var foundPerson = GetDataPerson(context, lastName);
                if (foundPerson == null)
                    return;

                context.DataPersons.Remove(foundPerson);
                context.SaveChanges();
            }
        }

        public void UpdateItems(IEnumerable<Person> updatedPeople)
        {
            throw new NotImplementedException();
        }

        private DataPerson GetDataPerson(PeopleEntities context, string lastName)
        {
            DataPerson foundPerson = null;
            foundPerson = (from p in context.DataPersons
                           where p.LastName == lastName
                           select p).FirstOrDefault();
            return foundPerson;
        }

        private Person GetPersonFromDataPerson(DataPerson dataPerson)
        {
            var person = new Person()
            {
                FirstName = dataPerson.FirstName,
                LastName = dataPerson.LastName,
                StartDate = dataPerson.StartDate.Value,
                Rating = dataPerson.Rating.Value,
            };
            return person;
        }

    }
}
