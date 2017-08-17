using OurAwesomeLibrary;

namespace ClientCode
{
    public class SomeClientClass
    {        
        public void SomeMethod()
        {
            var o = new AwesomeClass();

            o.Manual();

            o.Auto();

            o.AutoSpecificVersions();

            o.SuggestAnAlternativeReplacement();
        }

      
    }
}
