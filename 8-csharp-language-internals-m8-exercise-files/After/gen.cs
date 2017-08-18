using System;

class Program
{
  static void Main()
  {
    // Use WinDbg and SOS to !dumpheap -stat and spot the
    // generic instantiations. Use !dumpmt -md and !dumpclass
    // to inspect the method tables, method descriptors, and
    // EE classes.

    var b1 = new Bar<int>();
    var b2 = new Bar<string>();
    var b3 = new Bar<AppDomain>();

    Console.ReadLine();

    GC.KeepAlive(b1);
    GC.KeepAlive(b2);
    GC.KeepAlive(b3);
  }
}

class Bar<T>
{
  int x;
  T value;
  bool b;
}