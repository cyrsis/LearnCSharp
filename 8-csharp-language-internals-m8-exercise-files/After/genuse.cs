using System;

class Program
{
  static void Main()
  {
    // This won't compile unless Program also implements IFoo.
    var bar = new Bar<Program>();
    bar.Foo();
  }
}