using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
namespace AllCodeRush.Code.TypecastingConversion
{
	/* •—————————————————————————————————————————————————————————•
			Feature: Convert To Built-in Type
	         
			Use Case: Changes a reference to a system type into a 
	    reference to an appropriate built-in type.
		 
			Available: When the caret is on a reference to a system 
	    type. 
		•—————————————————————————————————————————————————————————• */

	public class Book
  {
		public System.String Title { get; set; }
		public String Author { get; set; }
		public System.Int32 Pages { get; set; }
		public Int32 Edition { get; set; }
	}
}
