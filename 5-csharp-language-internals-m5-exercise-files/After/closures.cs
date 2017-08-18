using System;

class Program
{
  static void Main()
  {
    int c = 2;

    Func<int, int> f = delegate (int x) // x => x * 2
    {
      return x * c;
    };

    c = 4;

    Console.WriteLine(f(3)); // 12
  }
}