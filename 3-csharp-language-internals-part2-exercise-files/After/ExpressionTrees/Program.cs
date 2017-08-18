using System;
using System.Linq;
using System.Linq.Expressions;

namespace ExpressionTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> f = () => 42;
            Expression<Func<int>> g = () => 42;
        }
    }
}
