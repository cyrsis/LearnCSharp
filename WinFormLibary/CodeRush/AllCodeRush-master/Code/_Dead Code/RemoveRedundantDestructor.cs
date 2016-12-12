using System;

namespace AllCodeRush.Code.DeadCode
{
	/* 風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧�
		  Feature: Remove Redundant Destructor.
        
		  Use Case: Removes an empty destructor.

	    Available: When the caret is at an empty destructor 
      declaration.
	   風覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧覧� */
	public class RemoveRedundantDestructor
	{
		~RemoveRedundantDestructor()
		{
			// This destructor serves no purpose.
		}
	}
}
