using System;

namespace AllCodeRush.Code.NamespacesTypeQualifiers
{
  /* •—————————————————————————————————————————————————————————•
      Feature: Introduce Alias (Replace All)
         
      Use Case: Introduces a new file-scoped alias for the 
      current type or namespace name, and replaces it with the 
      newly-created alias.
	 
      Available: When the caret is on a reference to a type. 
      This reference should contain namespace information. 
 
      See also: Introduce Alias, Inline Alias, Remove Type 
                Qualifier, Remove Type Qualifier (Remove All)
     •—————————————————————————————————————————————————————————• */

  public class IntroduceAliasReplaceAll
	{
		public Space.SolarSystem BuildPlanetarySystem()
		{
			Space.SolarSystem solarSystem = new Space.SolarSystem();
			solarSystem.Stars.Add(new Space.Bodies.Star() { Name = "Sol" });
			solarSystem.Planets.Add(new Space.Bodies.Planets.Planet() { Name = "Mercury" });
			solarSystem.Planets.Add(new Space.Bodies.Planets.Planet() { Name = "Earth" });
			solarSystem.Planets.Add(new Space.Bodies.Planets.Planet() { Name = "Mars" });
			solarSystem.Planets.Add(new Space.Bodies.Planets.Planet() { Name = "Jupiter" });
			solarSystem.Planets.Add(new Space.Bodies.Planets.Planet() { Name = "Neptune" });
			return solarSystem;
		}
	}
}
