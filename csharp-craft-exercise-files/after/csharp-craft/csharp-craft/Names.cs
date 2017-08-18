using System.Linq;

namespace csharp_craft
{
    
    
    
    public class PalindromeTester
    {       
        public bool Test(string strInput)
        {
            string strTrimmed = strInput.Replace(" ", "");
            string strReversed = new string(strTrimmed.Reverse().ToArray());
            return strReversed.Equals(strReversed);
        }

        public bool Check(string input)
        {
            input = input.Replace(" ", "");
            var reversed = new string(input.Reverse().ToArray());
            return reversed.Equals(input);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsPalindrome(string input)
        {
            var forwards = input.Replace(" ", "");
            var backwards = new string(forwards.Reverse().ToArray());
            return backwards.Equals(forwards);
        }
    }



















}

