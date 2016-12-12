using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parameters {
  class Program {
    static void Main(string[] args) {
      Method(42, b: "The answer");
      Method(42);
      Method( );

      Method(42, b: "The answer");
      Method(a: 42, b: "The answer");
      Method(b: "The answer", a: 42);
      Method(b: "Other text");

      Method(a: GetA( ), b: GetB( ));
      Method(b: GetB( ), a: GetA( ));

      var t1 = new Thing(1, 2);
      t1.Output( );
      var t2 = new Thing(1);
      t2.Output( );
      var t3 = new Thing( );
      t3.Output( );

      var t4 = new Thing(Y: 100);
      t4.Output( );

      DoSomething(5);
      DoSomething(x: 42);
      DoSomething(5, 3);
      DoSomething(x: 100, y: 13);
    }

    //static void DoSomething(int x) {
    //  Console.WriteLine("One param (int) DoSomething: x={0}", x);
    //}

    //static void DoSomething(double x) {
    //  Console.WriteLine("One param (double) DoSomething: x={0}", x);
    //}

    static void DoSomething<T>(T g) {
      Console.WriteLine("One param (generic) DoSomething: g={0}", g);
    }

    static void DoSomething(int x, int y = 20) {
      Console.WriteLine("Two params DoSomething: x={0}, y={1}", x, y);
    }

    static void Method(int a = 20, string b = "Test") {
      Console.WriteLine("a: {0}, b: {1}", a, b);
    }

    static int GetA( ) {
      Console.WriteLine("Getting A");
      return 10;
    }

    static string GetB( ) {
      Console.WriteLine("Getting B");
      return "Some text";
    }
  }

  public class Thing {
    public Thing(int X = 20, int Y = 30) {
      this.X = X;
      this.Y = Y;
    }
    public int X { get; set; }
    public int Y { get; set; }

    public void Output( ) {
      Console.WriteLine("X: {0}, Y: {1}", X, Y);
    }
  }
}
