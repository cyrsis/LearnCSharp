using System;
using SalesModel.DomainClasses.Enums;

namespace SalesModel.DomainClasses
{
  class ProductFeedback
  {
    public int Id { get; set; }
    public DateTime DateTime { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public ProductRating ProductRating { get; set; }
    public string Comments { get; set; }
  }
}
