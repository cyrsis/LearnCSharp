using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSFSDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDoc = new Document();
            myDoc.Print();
            myDoc.CountCharacters();

           // Printable mySecondDoc = new Printable();
            Printable printableItem = myDoc;
            printableItem.Print();
           // printableItem.CountCharacters();
            Document theDoc = printableItem as Document;
            if (theDoc != null)
                theDoc.CountCharacters();

            string contents = theDoc.Read();
            Console.WriteLine("contents: " + contents);

        }
    }
}
