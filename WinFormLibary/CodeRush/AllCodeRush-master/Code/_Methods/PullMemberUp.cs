using System;

namespace AllCodeRush.Code.Methods
{

  /* •————————————————————————————————————————————————————————•
      Feature: Pull Member Up
        
      Use Case: Lets you move a member up to any base type.
         
      Available: When the caret is on a class member, provided 
      that the base class is declared in the solution.
     •————————————————————————————————————————————————————————• */
  public class Shape2D
	{
    protected double height;
    protected double width;
	}

	public class Projection3D : Shape2D
	{
    private double depth;
    private string name;

    public double CalculateArea()
		{
			return width * height;
		}
    public double CalculateVolume()
		{
			return CalculateArea() * depth;
		}
  
    public string Name
    {
      get { return name; }
      set
      {
        name = value;
      }
    }
  }
}
