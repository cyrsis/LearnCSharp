using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_IEquatable
{
    public class Author : IEquatable<Author>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public bool Equals(Author other)
        {
            if (other == null) return false;
            if (FirstName != other.FirstName) return false;
            if (LastName != other.LastName) return false;
            return true;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Author);
        }

        public static bool operator ==(Author author1, Author author2)
        {
            if (Object.ReferenceEquals(author1, null))
                return Object.ReferenceEquals(author2, null);
            return author1.Equals(author2);
        }

        public static bool operator != (Author author1, Author author2)
        {
            return !(author1 == author2);
        }
        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ LastName.GetHashCode();
        }
    }
}
