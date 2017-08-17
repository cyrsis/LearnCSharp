using System;
using System.Diagnostics;
using System.Threading;
using Xunit;

namespace Demo.Tests
{
    public class ExtraConstraintsDemo
    {
        enum Colors
        {
            Red,
            Green,
            Blue
        }

        [Fact]
        public void Enums()
        {
            var colHelp = new EnumHelper<Colors>();

            var lastCol = colHelp.LastEnumValue();

            Assert.Equal(Colors.Blue, lastCol);
        }

        [Fact]
        public void Delegates()
        {
            var delHelp = new DelegateHelper<Action>();

            //var invalid = new DelegateHelper<Action<int>>();
            //var invalid2 = new DelegateHelper<Func<string>>();

            delHelp.ExecuteRandomDelegate(SayHi, SayBye);
            delHelp.ExecuteRandomDelegate(SayHi, SayBye);
            delHelp.ExecuteRandomDelegate(SayHi, SayBye);
            delHelp.ExecuteRandomDelegate(SayHi, SayBye);
            delHelp.ExecuteRandomDelegate(SayHi, SayBye);
        }


        private void  SayHi()
        {
            Debug.WriteLine("Hello");
            Thread.Sleep(33);    
        }

        private void SayBye()
        {
            Debug.WriteLine("Goodbye");
            Thread.Sleep(50);    
        }
    }
}
