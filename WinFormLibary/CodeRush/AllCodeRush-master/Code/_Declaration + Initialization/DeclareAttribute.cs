using System;

namespace AllCodeRush.Code.DeclarationInitialization
{
	/* •———————————————————————————————————————————————————————•
		  Feature: Declare Attribute
        
		  Use Case: Consume-first declaration of .NET Attribute 
      classes.
         
		  Available: When the caret is in a reference to an 
		  undeclared attribute.
		 •———————————————————————————————————————————————————————• */

	[CustomAttribute(Name="Super", Count=4)]
	public class DeclareAttribute
	{

	}
}
