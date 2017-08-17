using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using SalesModel.DataLayer;
using SalesModel.DomainClasses;
using System.Data.Entity;


namespace Repository
{
  public class SimpleCustomerRepository:IDisposable
  {
    readonly SalesModelContext _context = new SalesModelContext();

    public SimpleCustomerRepository()
    {
      App_Start.EntityFrameworkProfilerBootstrapper.PreStart();
    }

    public Customer NewCustomerWithContactDetail()
    {
      var customer = new Customer
      {
        ContactDetail = new ContactDetail()
      };
      _context.Customers.Add(customer);
      return customer;
    }

    public void AddNewCustomer(Customer customer)
    {
      _context.Customers.Add(customer);
    }

    public void UpdateCustomer(Customer customer)
    {
      _context.Entry(customer).State=EntityState.Modified;
    }
    public Customer GetCustomerGraph(int id)
    {
      return _context.Customers.Include(c => c.ContactDetail)
        .Include(c => c.Orders)
        .FirstOrDefault(c => c.CustomerId == id);
    }

    public Customer GetCustomerById(int id)
    {
      return _context.Customers.Find(id);
    }

    public List<Customer> GetCustomers()
    {
      return _context.Customers.ToList();
    }

    public ObservableCollection<Customer> CustomersInMemory()
    {
      if (_context.Customers.Local.Count == 0)
      {
        GetCustomers();
      }
      return _context.Customers.Local;
    } 

    public void Save()
    {
      _context.SaveChanges();
    }

    public void DeleteCustomer(int id)
    {
      var customer=_context.Customers.Find(id);
      _context.Customers.Remove(customer);
    }

    public void Dispose()
    {
      _context.Dispose(); 
    }

    
  }
}
