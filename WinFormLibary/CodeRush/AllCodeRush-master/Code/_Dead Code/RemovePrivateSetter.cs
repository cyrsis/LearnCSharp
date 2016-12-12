using System;

namespace AllCodeRush.Code.DeadCode.RemovePrivateSetter
{
  /* •———————————————————————————————————————————————————————————•
      Feature: Remove Private Setter.
        
      Use Case: Removes an private property setter that simply 
      assigns a value to a field without any side-effects.
	 
      Available: When the caret is caret is on a private property 
      setter, that only initializes the backing store field. 
     •———————————————————————————————————————————————————————————• */
  public class Customer
  {
    private DiscountLevelEnum discountLevel;
    public DiscountLevelEnum DiscountLevel
    {
      get { return discountLevel; }
      private set
      {
        discountLevel = value;
      }
    }

    private Customer()
    {
      // Set default discountLevel
      DiscountLevel = DiscountLevelEnum.Bronze;
    }

    #region Support
    public enum DiscountLevelEnum
    {
      Gold,
      Silver,
      Bronze
    }
    #endregion
  }
}
