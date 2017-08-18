using System;
using System.Linq.Expressions;

class Program
{
  static void Main()
  {
    Expression<Func<int>> f = () => 42;
               Func<int>  g = f.Compile();
    Console.WriteLine(g());
    Console.ReadLine();
    GC.KeepAlive(g);
  }
}