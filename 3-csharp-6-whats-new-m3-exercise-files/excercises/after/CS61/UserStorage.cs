using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;

namespace CS61
{
    public class UserStorage(int capacity = 128) : IEnumerable<User>
    {        
        public IEnumerator<User> GetEnumerator()
        {
            var allUsers = _defaultUsers.Select(kvp => kvp.Value)
                                        .Concat(_users);
                       
            return allUsers.GetEnumerator();          
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();   
        }

        public int Capacity { get; } = capacity;

        public User Insert(User newUser)
        {
            _users.Add(newUser);
            return newUser;
        }

        List<User> _users = new List<User>(capacity);

        Dictionary<string, User> _defaultUsers
            = new Dictionary<string, User>()
        {
                // note: dictionary init syntax not working yet in VS14
                { "admin", new User("admin") },
                { "guest", new User("guest") }
        };                 
    }
}
