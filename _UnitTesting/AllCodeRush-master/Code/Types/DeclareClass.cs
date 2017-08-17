using System;
using System.Collections.Generic;

namespace AllCodeRush.Code.Types
{
  /* •—————————————————————————————————————————————————————————•
			Feature: Declare Class
         
			Use Case: Generates a class for a current reference to a 
	    non-existent class. 
	 
			Available: When the caret is on a reference to a 
	    non-existent class. 
		 •—————————————————————————————————————————————————————————• */
  public class MissionControl
  {
    private List<RocketShip> _Rockets = new List<RocketShip>();
    public MissionControl()
    {
      // Build Default Rockets
      _Rockets.Add(new RocketShip() { Name = "Andromeda", Seats = 2, Fuel = 2000.0, Boosters = 4, Warheads = 0 });
      _Rockets.Add(new RocketShip() { Name = "X2376", Seats = 0, Fuel = 200.0, Boosters = 4, Warheads = 10 });
      Navigate.File.BrowseRecentFiles browseRecentFiles = new Navigate.File.BrowseRecentFiles();
    }
  }
}
