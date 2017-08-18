using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class InitializingMultidimensionalArraysExample
    {
        [TestMethod]
        public void RectangularArrays()
        {
            char[,] boardGameLetters = new char[2,2];

            boardGameLetters[0, 0] = 'A';
            boardGameLetters[0, 1] = 'B';
            boardGameLetters[1, 0] = 'C';
            boardGameLetters[1, 1] = 'D';

            char[,] boardGameLetters2 = new char[,]
                                   {
                                       {'A', 'B'},
                                       {'C', 'D'}
                                   };

            var boardGameLetters3 = new [,]
                                   {
                                       {'A', 'B'},
                                       {'C', 'D'}
                                   };
        }







        [TestMethod]
        public void JaggedArrays()
        {
            var boardGameLetters = new char[2][];

            // inner arrays start as null, so we have to create them
            boardGameLetters[0] = new char[3];
            boardGameLetters[0][0] = 'A';
            boardGameLetters[0][1] = 'B';
            boardGameLetters[0][2] = 'C';

            boardGameLetters[1] = new char[1];
            boardGameLetters[1][0] = 'D';


            var boardGameLetters2 = new[]
                                        {
                                            new[] {'A', 'B', 'C'},
                                            new[] {'D'}
                                        };
        }



        
    }
}
