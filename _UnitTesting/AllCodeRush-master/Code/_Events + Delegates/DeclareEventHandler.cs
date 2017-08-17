using System;

namespace AllCodeRush.Code.EventsDelegates
{
  /* •———————————————————————————————————————————————————————•
      Feature: Declare Event Handler
          
      Use Case: Declares the event handler at the caret.
           
      Available: When the caret is on an undeclared event 
      handler reference.
          
      See also: Declare Event 
     •———————————————————————————————————————————————————————• */

  public class DeclareEventHandler
  {
    private void ListenToClicks(OtherClass otherClass)
    {
      otherClass.Click += ClickHappened;
    }
  }
}
