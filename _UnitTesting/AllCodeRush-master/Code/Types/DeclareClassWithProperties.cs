using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.Types
{
	/* •—————————————————————————————————————————————————————————•
			Feature: Declare Class (With Properties)
         
			Use Case: Declares a class with properties initialized to 
	    the parameters passed to the constructor.  
	 
			Available: When the caret is on a reference to a 
	    constructor of a non-existent class, provided that the 
	    constructor has at least one parameter 
		 •—————————————————————————————————————————————————————————• */

	// Have not been able to make this work.

	public class School
	{
		private List<Classroom> _Classrooms = new List<Classroom>();
		public School()
		{
			_Classrooms.Add(new Classroom("ScienceLab"));
			_Classrooms.Add(new Classroom("Languages"));
			_Classrooms.Add(new Classroom("Math"));

		}
	}
}
