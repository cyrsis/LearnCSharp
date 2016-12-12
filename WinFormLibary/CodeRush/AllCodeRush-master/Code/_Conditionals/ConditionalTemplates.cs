using System;

namespace AllCodeRush.Code.Conditionals
{
  class ConditionalTemplates
  {
    public bool TemplatesForWorkingWithConditionals(bool testValue1, bool testValue2, bool testValue3)
    {
      // Basics...
      // b == {}
      // if == if ()
      // l == else


      //ifb, ifn, ifa

      // else blocks: lb, blb

      // lf == else if ()

      // and == &&
      // or == ||

      // Paren embedding.
      if (testValue1 || testValue2 && testValue3)
        testValue1 = false;

      return true;
    }

    MyControl control;
    public MyControl Control
    {
      get
      {
        // Copy the "control" field to the clipboard and then expand the "cod" template.

        return control;
      }
    }


    /* •————————————————————————————————————•
        Primitives:
          t  ==  true                     
          f  ==  false                    
          n  ==  null (or Nothing in VB)  
          "  ==  ""                       
          '  ==  ''                       
          th ==  this (or Me in VB)      
          me ==  this (or Me in VB)      
          se ==  String.Empty            
          1  ==  1                        
          0  ==  0                        
         -1  == -1                      
       •————————————————————————————————————• */

    public void ReturningFromConditionals(bool test, MyControl myControl)
    {
      // Out of scope, slightly...
      // r == Returning values

      // else return: lr + primitive shortcut 
      if (test)
      {
        // ...
      }
    }

    public void IfNullReturn(MyControl myControl)
    {
      // inr == if ({Paste} == null) then return;

      // inr {+ primitive shortcut} == if ({Paste} == null) then return {primitive value};


    }


    public void SettingAndTestingValues(bool test, int counter, string name)
    {
      // Out of scope, ever so slightly...
      // s ... Setting values (or testing to see if a value is Set to something) 
      // n ... tests to see if a value is Not set to something

      // s + primitive shortcut (both on an empty line and inside an expression)
      // n + primitive shortcut (both inside empty parens and to the right of an identifier)

      /* •—————————————————————————————————————————————————————————————————————————————————————————•
           Template:        s + primitive shortcut            :         n + primitive shortcut    
                                                              :
                                                              :       
           Expansion:       {Paste} == {primitive value}      :      {Paste} != {primitive value} 
                                                              :
                                                              :
           Try it:          on an empty line &                :      inside empty parens & 
                            inside an expression              :      to the right of an identifier
         •—————————————————————————————————————————————————————————————————————————————————————————• */

      string name = "Hello World";    // copy name to the clipboard, and use in the uncommented code below.
      //if ()
      //  if (name)
      //  {
      //  	
      //  }

      // sne = String.IsNullOrEmpty()
    }

    public void CheckingForValidAssignments(MyControl myControl)
    {
      // With myControl copied to the clipboard:
      // ifa, ifna

      // nn, sn (we've already seen these)
    }


    /* •————————————————————•
        Boolean Properties:      
          c  == Checked
          e  == Enabled
          sr == Sorted
          v  == Visible
       •————————————————————• */

    public void CheckingBooleanProperties(MyControl myControl)
    {
      // i = Identifier on the clipboard.
      // i + Boolean prop shortcut
      // Copy myControl to the clipboard...
      if (myControl.Checked)
      {

      }
    }

    /* •————————————————————————————————————•
        Integer Properties:
          bm == Bottom
          cn == Count
          ht == Height
          lt == Left
          ln == Length
          rt == Right
          tp == Top
          wd == Width
     
        String Properties:
          nm == Name
          tx == Text

        Other Common Properties:
          cr == ClientRectangle
          pa == Parent
          sz == Size
     •————————————————————————————————————• */

    public void CheckingOtherProperties(MyControl myControl)
    {
      // Copy myControl to the clipboard...

      // i + prop shortcut
      // s + prop shortcut (inside an expression)
      //                  ...if it's an int prop, optionally followed by 0, 1, or -1
    }
  }
}
