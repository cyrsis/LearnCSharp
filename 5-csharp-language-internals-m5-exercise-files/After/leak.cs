using System;

class Program
{
  Func<int, int> f;

  static void Main()
  {
    int c = 2;
    byte[] b = new byte[64 * 1024 * 1024];

    f = x => x * c;
    Action a = () => Console.WriteLine(b.Length);

    Console.WriteLine(f(3));
    a();

    GC.Collect();

    Console.Read();
  }
}