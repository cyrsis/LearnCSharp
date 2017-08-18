using System;
using System.Linq;

class Program
{
  static void Main()
  {
    var res = from x in new int[0]
              let y = x * 2 //
              select x * y;
  }
}