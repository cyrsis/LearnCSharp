using System;

namespace AllCodeRush.Code.EventsDelegates
{
  /* ?????????????????????????????      Feature: Create Event Trigger
          
      Use Case: Declares an triggering method for the event 
      at the caret.
           
      Available: When the caret is an event declaration
      reference.
          
      See also: Declare Event Handler
     ?????????????????????????????*/

  public class CreateEventTrigger
  {
    public event EventHandler StateChanged;
    public event UnhandledExceptionEventHandler UnhandledExceptionEvent;
    public event EventHandler<OtherClass> Clicked;
  }
}
