using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmells
{
    public class LongParameterList
    {
        public SuperImportantReturnType Process(Person p)
        {
            /*
             * 
             * Super Important Calculation to determine the likelyhood of future successful investments.
             * 
             */
            return new SuperImportantReturnType();
        }
    }

    public class Person
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public int Age {get; set;}
        public int Weight {get; set;}
        public string EyeColor {get; set;}
        public string HairColor {get; set;}
        public decimal ShoeSize {get; set;}
        public int PantWidth {get; set;}
        public int PantHeight { get; set; }
    }
}
