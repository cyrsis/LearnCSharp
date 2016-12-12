using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicBasics {
  class Program {
    static void Main(string[] args) {
      dynamic i = 42;
      dynamic s = "Hi there";

      Console.WriteLine( "Length of my string " + s.Length);

      //i.DoSomethingImpossible( );

      var things = new dynamic[] { 42, "text value" };
      var things_ = new List<dynamic> { 42, "text value" };

      foreach(dynamic thing in things)
        Console.WriteLine(thing);

      foreach(dynamic thing in GetStuff())
        Console.WriteLine(thing);

        Console.ReadLine();
    }

    //dynamic k;

    static IEnumerable<dynamic> GetStuff( ) {
      yield return "a string";
      yield return 42;
      yield return true;
    }

    static void UseDynamicThing(dynamic thing) {
      
    }
  }

  //public class Test : IEnumerable<dynamic> {

  //}
}
