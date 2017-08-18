using System;

class Program
{
  static void Main()
  {
    Func<int, int> f = delegate (int x) // x => x * 2
    {
      return x * 2;
    };
  }
}