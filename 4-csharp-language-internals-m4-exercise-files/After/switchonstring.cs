using System;

class Program
{
  static int Main(string[] args)
  {
    switch (args[0])
    {
      case null : return  0;
      case "bar": return  1;
      case "foo": return  2;
      case "qux": return  3;
      case "baz": return  4;
      case "ham": return  5;
      default   : return -1;
    }
  }
}