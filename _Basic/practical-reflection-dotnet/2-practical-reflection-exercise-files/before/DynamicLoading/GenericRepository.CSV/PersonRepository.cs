using PeopleViewer.SharedObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericRepository.Interface;

namespace GenericRepository.CSV
{
    public class PersonRepository : IRepository<Person, string>
    {
        string path;

        public PersonRepository()
        {
            var filename = ConfigurationManager.AppSettings["CSVFileName"];
            path = AppDomain.CurrentDomain.BaseDirectory + filename;
        }

        public IEnumerable<Person> GetItems()
        {
            var people = new List<Person>();

            if (File.Exists(path))
            {
                using (var sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var elems = line.Split(',');
                        var per = new Person()
                        {
                            FirstName = elems[0],
                            LastName = elems[1],
                            StartDate = DateTime.Parse(elems[2]),
                            Rating = Int32.Parse(elems[3])
                        };
                        people.Add(per);
                    }
                }
            }
            return people;
        }

        public Person GetItem(string lastName)
        {
            Person selPerson = new Person();
            if (File.Exists(path))
            {
                var sr = new StreamReader(path);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var elems = line.Split(',');
                    if (elems[1].ToLower() == lastName.ToLower())
                    {
                        selPerson.FirstName = elems[0];
                        selPerson.LastName = elems[1];
                        selPerson.StartDate = DateTime.Parse(elems[2]);
                        selPerson.Rating = Int32.Parse(elems[3]);
                    }
                }
            }

            return selPerson;
        }

        public void AddItem(Person newPerson)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(string lastName, Person updatedPerson)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(string lastName)
        {
            throw new NotImplementedException();
        }

        public void UpdateItems(IEnumerable<Person> updatedPeople)
        {
            throw new NotImplementedException();
        }
    }
}
