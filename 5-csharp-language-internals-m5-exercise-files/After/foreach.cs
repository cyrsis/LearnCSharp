using System;
using System.Threading;

class Program
{
  static void Main()
  {
    foreach (var x in new[] { 2, 3, 5, 7 })
      new Thread(() => Console.WriteLine(x)).Start();

    Console.Read();
  }
}