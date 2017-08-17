using Xunit;

namespace Demo.Tests
{
    public class CaselessDemo
    {
        [Fact]
        public void Equality()
        {
            const string name1 = "Sarah";
            const string name2 = "sarah";

            var areEqual = StringThings.AreEqual(name1, name2);
        }

        [Fact]
        public void Inequality()
        {
            const string name1 = "Sarah";
            const string name2 = "sarah";

            var notEqual = StringThings.NotEqual(name1, name2);
        }


        [Fact]
        public void Contains()
        {
            const string sentence = "It took Sarah several attempts.";
            const string name = "sarah";

            var containsSarah = StringThings.Contains(sentence, name);
        }

        // Caseless will convert the following to use StringComparison:
        //   - Compare(String,String)
        //   - CompareTo(String)
        //   - Contains(String)
        //   - EndsWith(String)
        //   - Equality 
        //   - Equals(String)
        //   - Equals(String, String)
        //   - IndexOf(String)
        //   - IndexOf(String, Int)
        //   - IndexOf(String, Int, Int)
        //   - Inequality
        //   - LastIndexOf(String)
        //   - LastIndexOf(String, Int)
        //   - LastIndexOf(String, Int, Int)
        //   - StartsWith(String)


    }
}
