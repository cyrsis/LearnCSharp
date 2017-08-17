using System;

namespace AllCodeRush.Code.DeclarationInitialization
{
	/* •———————————————————————————————————————————————————————•
		  Feature: Declare Enum Element
        
		  Use Case: Consume-first declaration of enum elements.
         
		  Available: When the caret is on a reference to an 
		  undeclared enum element.
		 •———————————————————————————————————————————————————————• */

	public class DeclareEnumElement
	{
		public enum DifficultyLevel
		{
      Beginner,
			Intermediate
		}

    public bool CanTakeCourse(DifficultyLevel courseLevel, DifficultyLevel customerLevel)
		{
      if (customerLevel == DifficultyLevel.Beginner)
        return courseLevel == DifficultyLevel.Beginner;


      if (customerLevel == DifficultyLevel.Intermediate)
        return courseLevel == DifficultyLevel.Beginner || 
               courseLevel == DifficultyLevel.Intermediate;

      if (customerLevel == DifficultyLevel.Advanced)
        return true;

      return false;
		}
	}

}
