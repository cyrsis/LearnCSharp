using System;

class Program
{
  static void Main()
  {
    
  }

  static void Foo(int a, int b)
  {
    if (a > b)
      Console.WriteLine(">");
    else if (a < b)
      Console.WriteLine("<");
    else
      Console.WriteLine("=");
  }
}