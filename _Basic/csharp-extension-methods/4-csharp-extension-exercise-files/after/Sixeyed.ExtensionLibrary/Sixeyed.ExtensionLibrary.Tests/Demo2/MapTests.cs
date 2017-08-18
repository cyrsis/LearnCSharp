using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq.Expressions;

namespace Sixeyed.ExtensionLibrary.Tests.Demo2
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }
    }

    public class UserModel
    {
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }
    }

    [TestClass]
    public class MapTests
    {
        [TestMethod]
        public void WithStringReflection()
        {
            var source = new User
            {
                FirstName = "Elton",
                LastName = "Stoneman",
                BirthDate = new DateTime(1980, 1, 1)
            };

            var map = new Map<User, UserModel>(source);
            map.Populate("DateOfBirth", "BirthDate")
                .Populate("Name", s => s.FirstName + " " + s.LastName)
               .Populate("Age", s => (int)DateTime.Today.Subtract(s.BirthDate).TotalDays / 365);

            var target = map.Target;
            Assert.AreEqual("Elton Stoneman", target.Name);
            Assert.AreEqual(source.BirthDate, target.DateOfBirth);
            Assert.AreEqual(33, target.Age);
        }

        [TestMethod]
        public void WithExpressionReflection()
        {
            
            var source = new User
            {
                FirstName = "Elton",
                LastName = "Stoneman",
                BirthDate = new DateTime(1980, 1, 1)
            };

            

            var map = new Map<User, UserModel>(source);
            map.Populate(t => t.DateOfBirth, s => s.BirthDate)
                .Populate(t => t.Name, s => s.FirstName + " " + s.LastName)
               .Populate(t => t.Age, s => (int)DateTime.Today.Subtract(s.BirthDate).TotalDays / 365);

            var target = map.Target;
            Assert.AreEqual("Elton Stoneman", target.Name);
            Assert.AreEqual(source.BirthDate, target.DateOfBirth);
            Assert.AreEqual(33, target.Age);
        }
    }
}