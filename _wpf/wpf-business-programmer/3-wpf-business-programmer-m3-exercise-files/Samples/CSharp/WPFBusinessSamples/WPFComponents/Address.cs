using System;
using System.Text;

namespace WPFComponents
{
  public class Address
  {
    public string Street1 { get; set; }
    public string Street2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }

    public string GetAddress()
    {
      StringBuilder sb = new StringBuilder();

      sb.Append(Street1 + Environment.NewLine);
      sb.Append(Street2 + Environment.NewLine);
      sb.Append(City + ", " + State + "  " + PostalCode);

      return sb.ToString();
    }

    public Address CreateSample()
    {
      Address addr = new Address();

      addr.Street1 = "17852 E. 17th Street";
      addr.Street2 = "Suite 205";
      addr.City = "Tustin";
      addr.State = "CA";
      addr.PostalCode = "92780";

      return addr;
    }
  }
}
