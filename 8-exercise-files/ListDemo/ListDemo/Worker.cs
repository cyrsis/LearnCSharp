using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
   public class Worker
   {
      public Worker()
      {
         Work();
      }

      public void Work()
      {
         Dictionary<string, Person> dict = new Dictionary<string, Person>();
         Person george = new Person() { Name = "George Washington", Age = 67 };
         string key = "George";
         dict.Add(key, george);

         dict.Add("john", new Person() { Name = "John Adams", Age = 90 });
         dict.Add("thom", new Person() { Name = "Thomas Jefferson", Age = 91 });
         dict.Add("james", new Person() { Name = "James Madison", Age = 85 });

         Person secondPresident = dict["john"];
         Console.WriteLine($"The second president was: {secondPresident.Name}");
      }
   }
}
