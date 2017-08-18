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

        /*
        [TestMethod]
        public void WithExpressionReflectionSample()
        {
var user = new User() { FirstName = "Elton" };
var reader = new ObjectReader<User>(user);
Assert.AreEqual("Elton", reader.GetValue<string>("FirstName")); //1
Assert.AreEqual("Elton", reader.GetValue(x => x.FirstName)); //2
        }

        public class ObjectReader<TSource>
        {
            public TSource Source { get; set; }

            public ObjectReader(TSource source)
            {
                Source = source;
            }

            public T GetValue<T>(string propertyName)
            {
                var sourceAccessor = typeof(TSource).GetProperty(propertyName);
                return(T) sourceAccessor.GetValue(Source, null);
            }

            public T GetValue<T>(Expression<Func<TSource, T>> targetPropertyExpression)
            {
                var sourceAccessor = targetPropertyExpression.ToPropertyInfo();
                return (T)sourceAccessor.GetValue(Source, null);
            }
        }
         * */
    }
}