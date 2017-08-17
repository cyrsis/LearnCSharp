using System;

namespace AllCodeRush.Code.Conditionals
{
  /* •———————————————————————————————————————————————————————•
      Feature: Reverse Conditional
                                                            
      Use Case: Reverses the if/else blocks and negates the 
      expression. Useful when the expression of an if-block
      would be easier to read when negated.
                                                            
      Available: When the caret is on the "if" keyword of
      an if-statement with a corresponding else block.
           
      For more information on formatting code, see the "Code 
      Formatting" video.
     •———————————————————————————————————————————————————————• */
  public class ReverseConditional
  {
    public bool IsNorthWestOrSouthEast(double angle)
    {
      NormalizeAngle(ref angle);

      if (angle >= 90 && (angle >= 270 || angle <= 180))
        return false;
      else
        return true;
    }

    private void NormalizeAngle(ref double angle)
    {
      while (angle < 0)
        angle += 360.0;
      while (angle > 360.0)
        angle -= 360.0;
    }
  }
}
