using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingOneWay
{
   public class Employee
   {
      public string Name { get; set; }
      public string Title { get; set; }

      public static Employee GetEmployee()
      {
         var emp = new Employee()
         {
            Name = "Tom",
            Title = "Developer"
         };
         return emp;
      }

   }
}
