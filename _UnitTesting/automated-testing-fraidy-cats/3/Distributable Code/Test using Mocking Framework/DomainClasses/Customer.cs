using System;
using System.Collections.Generic;

namespace SalesModel.DomainClasses
{
  public class Customer : StateInfo
  {
    private ICollection<Address> _addresses;
    private ICollection<Order> _orders;
    private string _lastName;

    public Customer()
    {
      FirstName = "";
      LastName = "";
      DateOfBirth = DateTime.Today;
      _orders = new List<Order>();
      _addresses = new List<Address>();
      IsDirty = false;
    }

    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName
    {
      get { return _lastName; }
      set
      {
        if (value.Length > 50)
        {
          throw new InvalidOperationException("String too long. Max length is 50");
        }
        _lastName = value;
      }
    }
    public DateTime DateOfBirth { get; set; }
    public ContactDetail ContactDetail { get; set; }

    public ICollection<Order> Orders
    {
      get { return _orders; }
      set { _orders = value; }
    }
    public ICollection<Address> Addresses
    {
      get { return _addresses; }
      set { _addresses = value; }
    }

    public string FullName
    {
      get
      {
        return LastName.Trim() + ", " + FirstName;
      }
    }

    public DateTime LastUpdated
    {
      get
      {
        if (ContactDetail != null)
        {
          if (ModifiedDate > ContactDetail.ModifiedDate)
          {
            return ModifiedDate;
          }

          return ContactDetail.ModifiedDate;
        }
        return ModifiedDate;
      }
    }
  }
}