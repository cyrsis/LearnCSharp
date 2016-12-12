using System;

namespace AllCodeRush.Code.NamespacesTypeQualifiers
{
  /* •—————————————————————————————————————————————————————————•
      Feature: Use Short Notation
         
      Use Case: Converts the explicit form of a nullable type 
      reference to its short form.
	 
      Available: When the cursor is on an explicit form 
      reference to the nullable type.

      See also: Use Explicit Notation 
     •—————————————————————————————————————————————————————————• */

  public class UseShortNotation
	{
		Nullable <bool> catLives;

		public void CheckOnShrodingersCat()
		{
			if (!catLives.HasValue)
				Console.WriteLine("Anything is still possible.");
      else if (catLives.Value)
        Console.WriteLine("Hurrah, the cat is alive and well.");
      else
        Console.WriteLine("The cat isn't moving.");
		}

	}
}
