using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class LinqQueryAndFluentSyntax
    {
        private static readonly List<string> Names = new List<string>
                                  {
                                      "Sarah",
                                      "Gentry",
                                      "Mike"
                                  };


        [TestMethod]
        public void SingleOperator()
        {
            var querySyntax = from n in Names
                                         where n == "Mike"
                                         select n;

            var fluentSyntax = Names.Where(x => x == "Mike");
        }









        [TestMethod]
        public void SimpleWhereOrderBySelect()
        {  
            var querySyntax = from n in Names
                                         where n.Length > 4
                                         orderby n
                                         select n.ToUpper();


            var fluentSyntax = Names.Where(x => x.Length > 4)
                                                    .OrderBy(x => x)
                                                    .Select(x => x.ToUpper());
        }









        [TestMethod]
        public void NoQuerySyntaxKeyword()
        {
            var things = new List<object>
                             {
                                 "Sarah",
                                 42,
                                 'q',
                                 "Gentry"
                             };

            var fluentSyntax = things.OfType<string>()
                                                  .Select(x => x.ToUpper());

            var mixedSyntax = from t in things.OfType<string>()
                                          select t.ToUpper();
        }

  

    }
}