using System;

class Program
{
  static void Main()
  {
    dynamic x = Add(1, 2);
    Console.WriteLine((object)x);
    Console.ReadLine();

    dynamic d = Add(new DateTime(2014, 1, 1), TimeSpan.Zero);
    Console.WriteLine((object)d);
    Console.ReadLine();

    dynamic s = Add("Hello, ", "Dynamic!");
    Console.WriteLine((object)s);
    Console.ReadLine();

    dynamic y = Add(3, 4);
    Console.WriteLine((object)y);
    Console.ReadLine();
  }

  static dynamic Add(dynamic a, dynamic b)
  {
    return a + b;
  }
}