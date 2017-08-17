using System.Data.Spatial;
using System.Linq;
using SalesModel.DomainClasses.Enums;

namespace SalesModel.DataLayer.Migrations
{
  using DomainClasses;
  using System;
  using System.Collections.Generic;
  using System.Data.Entity.Migrations;

  public sealed class Configuration : DbMigrationsConfiguration<SalesModel.DataLayer.SalesModelContext>
  {
    public Configuration()
    {

      AutomaticMigrationsEnabled = true;
      AutomaticMigrationDataLossAllowed = true;
    }

    protected override void Seed(SalesModelContext context)
    {
      if (!context.Customers.Any())
      {
        var customers = new List<Customer>
                          {
                            new Customer
                              {
                                FirstName = "Sampson",
                                LastName = "TheNewfie",
                                DateOfBirth = new DateTime(2008, 1, 28),
                                ContactDetail = new ContactDetail()
                              },
                            new Customer
                              {
                                FirstName = "Yogi",
                                LastName = "TheBear",
                                DateOfBirth = new DateTime(1958, 1, 1),
                                ContactDetail = new ContactDetail()
                              }
                          };
        context.Customers.AddOrUpdate(
          c => new { c.FirstName, c.LastName }, customers.ToArray());

        var dogstuff = new Category() { Name = "Dog stuff" };
        var bearstuff = new Category() { Name = "Bear stuff" };
        var products = new List<Product>()
                         {
                           new Product()
                             {
                               Name = "Bone",
                               Description = "Juicy Dog Bone",
                               Categories = {dogstuff},
                               ProductionStart = DateTime.Now
                             },
                           new Product()
                             {
                               Name = "Katie's Bumper Toy",
                               Description = "Super fun dog toy",
                               Categories = {dogstuff},
                               ProductionStart = DateTime.Now
                             },
                           new Product()
                             {
                               Name = "Picnic Basket",
                               Description = "To carry your food",
                               Categories = {bearstuff},
                               ProductionStart = DateTime.Now
                             },
                           new Product()
                             {
                               Name = "Honey",
                               Description = "For bears who like honey",
                               Categories = {bearstuff},
                               ProductionStart = DateTime.Now
                             }
                         };
        context.Products.AddOrUpdate(p => p.Name, products.ToArray());
        CreateCustomerWithOrder(context);
      }
    }
    private static void CreateCustomerWithOrder(SalesModelContext context)
    {
      var product1 = context.Products.Local[0];
      var product2 = context.Products.Local[1];
      var customer = new Customer
      {
        FirstName = "Julie",
        LastName = "Lerman",
        ContactDetail = new ContactDetail
        {
          TwitterAlias = "julielerman"
        },
        DateOfBirth = DateTime.Now
      };
      var order = new Order
      {
        DestinationLatLong = DbGeography.FromText("POINT(44.292401 -72.968102)"),
        OrderDate = DateTime.Now,
        OrderSource = OrderSource.InPerson};
      if (product1.ProductId > 0)
      {
        order.LineItems =new List<LineItem>
          {
            new LineItem {ProductId = product1.ProductId, Quantity = 2},
            new LineItem {ProductId = product2.ProductId, Quantity = 1}};
      }
      else
      {
        order.LineItems =
          new List<LineItem>
            {
              new LineItem {Product = product1, Quantity = 2},
              new LineItem {Product = product2, Quantity = 1}
            };
      }
      customer.Orders.Add(order);
      context.Customers.Add(customer);
    }
  }
}

