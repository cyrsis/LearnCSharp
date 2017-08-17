using System;

namespace WPFComponents
{
  public class MyCustomer
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName
    {
      get { return FirstName + " " + LastName; }
    }
  }
}
