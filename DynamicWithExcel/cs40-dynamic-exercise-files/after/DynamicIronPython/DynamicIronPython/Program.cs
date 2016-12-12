using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IronPython.Hosting;

namespace DynamicIronPython {
  class Program {
    static void Main(string[] args) {
      var python = Python.CreateRuntime( );
      dynamic script = python.UseFile("script.py");
      script.SayHi( );

      script.SpecialCSharpValue = 7777;
      script.OutputValue( );
    }
  }
}
