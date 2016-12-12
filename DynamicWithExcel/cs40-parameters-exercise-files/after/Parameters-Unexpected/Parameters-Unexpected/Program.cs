using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parameters_Unexpected {
  class Program {
    static void Main(string[] args) {
      var man = new Man( );
      man.Walk( );
      var human = (Human) man;
      human.Walk( );

      human.Calculate(1, 2);
      man.Calculate(1, 2);

      human.Calculate(x: 1, y: 2);
      man.Calculate(x: 1, y: 2);
    }
  }

  public class Human {
    public virtual void Walk( ) {
      Console.WriteLine("Human walking");
    }

    public virtual void Calculate(int x, int y) {
      Console.WriteLine("Human calculating with x: {0}, y: {1}", x, y);
    }
  }

  public class Man : Human {
    public override void Walk( ) {
      Console.WriteLine("Man walking");
    }

    public override void Calculate(int y, int x) {
      Console.WriteLine("Man calculating with x: {0}, y: {1}", x, y);
    }
  }
}
