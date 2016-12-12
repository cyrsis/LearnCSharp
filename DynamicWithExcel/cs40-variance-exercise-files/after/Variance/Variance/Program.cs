using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variance {
  class Program {
    static void Main(string[] args) {
      var strings = new List<string> { "one", "two" };
      strings.Add("three");
      var ilistStrings = (IList<string>) strings;
      ilistStrings.Add("four");

            foreach (var item in ilistStrings)
            {
                Console.WriteLine(item);
            }

            //var objectList = (IList<object>) strings;
            //objectList.Add(42);

            var objectSequence = (IEnumerable<object>) strings;

      IComparer<string> comparer;

        Console.ReadLine();
    }
  }
}
