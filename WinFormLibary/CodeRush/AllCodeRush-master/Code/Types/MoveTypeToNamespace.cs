using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.Wrong.Namespace
{
	/* •—————————————————————————————————————————————————————————•
			Feature: Move Type To Namespace
         
			Use Case: Relocates a type to a different namespace 
	    existing in the current solution and updates all references.
	 
			Available: When the caret is on a type declaration. 
		 •—————————————————————————————————————————————————————————• */
	public class ProviderClass
	{
		
	}
}
namespace AllCodeRush.Code.Another.Namespace
{
	public class ConsumerClass
	{
		public ConsumerClass()
		{
			var _list = new List<AllCodeRush.Code.Wrong.Namespace.ProviderClass>();
		}
	}
}
