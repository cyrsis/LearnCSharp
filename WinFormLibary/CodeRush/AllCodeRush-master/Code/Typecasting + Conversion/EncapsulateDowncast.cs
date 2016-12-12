using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.TypecastingConversion
{
	/* •—————————————————————————————————————————————————————————•
			Feature: Encapsulate Downcast
	         
			Use Case: Changes the return type of a method to the type 
	    that all callers downcast to, removing typecasting at 
	    calling sites.
		 
			Available: When the caret is on a method declaration 
	    statement, provided that the method's return type is the 
	    ancestor of the method's return value.
		•—————————————————————————————————————————————————————————• */

	// Cant find how to make this available.
	public class EncapsulateDowncast
	{
		private void Calculate()
		{
			Calculator Calc = new Calculator();
			int RunningTotal = 0;
			RunningTotal = (int)Calc.Add(1000);
			RunningTotal = (int)Calc.Add(100);
			RunningTotal = (int)Calc.Add(10);
			RunningTotal = (int)Calc.Add(1);

		}
	}
	public class Calculator
	{
		private double _runningTotal;
		private void Clear()
		{
			_runningTotal = 0;
		}
		public double Add(int Value)
		{
			_runningTotal += Value;
			return _runningTotal;
		}
	}
}
