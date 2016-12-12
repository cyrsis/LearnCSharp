using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Students
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
            int result = this.ToString().CompareTo(other.ToString());
            if (result != 0) return result;
            return this.StudentId.CompareTo(other.StudentId);
        }
    }
}
