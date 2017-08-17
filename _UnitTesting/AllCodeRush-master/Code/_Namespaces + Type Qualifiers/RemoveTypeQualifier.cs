using System;

namespace AllCodeRush.Code.NamespacesTypeQualifiers
{
  /* •—————————————————————————————————————————————————————————•
      Feature: Remove Type Qualifier
         
      Use Case: Removes a type qualifier (namespaces) from a 
      type reference and ensures the proper namespace reference 
      is added to the file if needed.
	 
      Available: When the caret is on a type reference that 
      contains namespace information.

      See also: Inline Alias, Introduce Alias, 
                Remove Type Qualifier (Remove All)
     •—————————————————————————————————————————————————————————• */

  public class RemoveTypeQualifier
	{
    public static Space.Galaxy PartialGalaxySimulation()
    {
      Space.Galaxy Galaxy = new Space.Galaxy();
      Galaxy.Stars.Add(new Space.Bodies.Star { Name = "Sol" });
      Galaxy.Stars.Add(new Space.Bodies.Star { Name = "Altair" });
      Galaxy.Stars.Add(new Space.Bodies.Star { Name = "Eranin" });
      Galaxy.Stars.Add(new Space.Bodies.Star { Name = "Wolf 359" });
      return Galaxy;
    }

	}
}
