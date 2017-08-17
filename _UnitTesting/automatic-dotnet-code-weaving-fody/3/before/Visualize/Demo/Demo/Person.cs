using System.Diagnostics;

namespace Demo
{
    [DebuggerDisplay("Name = {Name} | Age = {Age} | HomeTown = {HomeTown} | Password = {Password}")]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
        public string Password { get; set; }
    }
}