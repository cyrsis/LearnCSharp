using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesModel.DomainClasses
{
  public class LineItem : StateInfo,IValidatableObject
  {
    public int LineItemId { get; set; }
    public int Quantity { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
  

    public Order Order { get; set; }
    public virtual Product Product { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      if (Quantity < 1)
      {
        yield return new ValidationResult
         ("Quantity must be greater than 0",
           new[] { "Quantity" });
      }
    }
  }
} 