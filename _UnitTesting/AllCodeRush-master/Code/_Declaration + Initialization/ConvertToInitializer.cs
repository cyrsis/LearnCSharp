using System;

namespace AllCodeRush.Code.DeclarationInitialization
{
	/* •———————————————————————————————————————————————————————•
		  Feature: Convert To Initializer
        
		  Use Case: Converts property-setting code lines into an 
      initializer.
         
		  Available: When the caret is placed on the name of an 
		  initialized object, provided at least one following line 
		  assigns a value to any property of this object. 
        
		  See also: Decompose Initializer
		 •———————————————————————————————————————————————————————• */

	public class ConvertToInitializer
	{
		public Building CreateBuilding()
		{
			Building building = new Building();
      building.Name = "Acme Anvils";
			building.Floors = 5;
			building.Sublevels = 2;
			return building;
		}
	}
}