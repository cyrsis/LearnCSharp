using System;

namespace AllCodeRush.Code.Expressions
{
  /* •———————————————————————————————————————————————————————•
      Feature: Inline Result
        
      Use Case: Replaces final assignments to the 
      temporary variable with a statement that immediately 
      returns the value.
         
      Available: When the caret is on a local variable whose 
      value is returned by this method.
        
      See also: Introduce Result Variable
     •———————————————————————————————————————————————————————• */

  public class InlineResult
  {
    public enum Suit
    {
      None,
      Hearts,
      Diamonds,
      Clubs,
      Spades
    }

    public bool CardIsRed(Suit suit)
    {
      bool result;
      switch (suit)
      {
        case InlineResult.Suit.Hearts:
          result = true;
          break;
        case InlineResult.Suit.Diamonds:
          result = true;
          break;
        case InlineResult.Suit.Clubs:
          result = false;
          break;
        case InlineResult.Suit.Spades:
          result = false;
          break;
        default:
          result = false;
          break;
      }
      return result;
    }
  }
}
