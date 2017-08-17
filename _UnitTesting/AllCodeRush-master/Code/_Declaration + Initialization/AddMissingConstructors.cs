using System;

namespace AllCodeRush.Code.DeclarationInitialization
{
  /* •—————————————————————————————————————————————————————————————•
      Feature: Add Missing Constructors
        
      Use Case: Adds base class constructors to a descendant class
         
      Available: When the caret is on a class declaration within 
      its name, provided that the base class contains at least 
      one constructor that is not implemented in the current class. 
     •—————————————————————————————————————————————————————————————• */

  public class AddMissingConstructors : AspectRatio
  {

  }

  public class AspectRatio
	{
    private readonly int height;
    private readonly int width;

    public AspectRatio(int edge): this(edge, edge)
		{
      
		}
		public AspectRatio(int height, int width)
		{
      this.width = width;
      this.height = height;
		}
	}
}
