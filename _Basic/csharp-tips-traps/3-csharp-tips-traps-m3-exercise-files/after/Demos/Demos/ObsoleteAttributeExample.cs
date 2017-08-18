using System;

namespace Demos
{    
    public class ObsoleteAttributeExample
    {
        public void ReferencesToObsolete()
        {
            // uncomment these uses to see compiler warnings and errors

            //new UseAtTheClassLevel();

            //new UseAtTheClassLevelWithMessage();

            //var a = new UseOnIndividualMembers();
            //a.Name = "Sarah";

            //new UseAtTheClassLevelWithCompilerError();
        }
    }

    [Obsolete]
    public class UseAtTheClassLevel {} 
    

    [Obsolete("Use class X from now on")]
    public class UseAtTheClassLevelWithMessage {}


    public class UseOnIndividualMembers
    {
        [Obsolete("Use FullName property from now on")]
        public string Name { get; set; }
        
        public string FullName { get; set; }
    }

    [Obsolete("This class can no longer be used", true)]
    public class UseAtTheClassLevelWithCompilerError { } 
}
