using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Students_2
{
    public class Student : IComparable<Student>
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Student(int studentId, string firstName, string lastName)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + " (" +
                StudentId.ToString() + ")";
        }

        public int CompareTo(Student other)
        {
            // Compare last names.
            int result = this.LastName.CompareTo(other.LastName);
            if (result != 0) return result;

            // Last names match. Compare first names.
            result = this.FirstName.CompareTo(other.FirstName);
            if (result != 0) return result;

            // Last and first names match. Compare student IDs.
            return this.StudentId.CompareTo(other.StudentId);
        }
    }
}
