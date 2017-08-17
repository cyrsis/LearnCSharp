using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace WPFTemplateApp
{
  public class EmployeeManager
  {
    #region GetEmployees Methods
    public ObservableCollection<Employee> GetEmployees()
    {
      ObservableCollection<Employee> ret;
      string fileName;

      try
      {
        fileName = WPFCommon.GetCurrentDirectory() +
          @"\Xml\Employee.xml";

        if (File.Exists(fileName))
          ret = GetEmployees(fileName);
        else
          ret = GetEmployeeMocks();
      }
      catch (Exception ex)
      {
        Debug.WriteLine(ex.ToString());
        // Still return some data
        ret = GetEmployeeMocks();
      }

      return ret;
    }

    protected ObservableCollection<Employee> GetEmployees(string fileName)
    {
      ObservableCollection<Employee> ret;
      XElement elem = XElement.Load(fileName);

      var items = 
        from emp in elem.Descendants("Employee")
        select new Employee
        {
         EmployeeNumber = Convert.ToInt32(emp.Element("EmployeeNumber").Value),
         FirstName = emp.Element("FirstName").Value,
         LastName = emp.Element("LastName").Value,
         SSN = emp.Element("SSN").Value
        };

      ret = new ObservableCollection<Employee>(items);

      return ret;
    }
    #endregion

    #region Insert Method
    public int Insert(Employee entity)
    {
      int ret = 0;

      // TODO: Insert Data Here

      return ret;
    }
    #endregion

    #region Update Method
    public int Update(Employee entity)
    {
      int ret = 0;

      // TODO: Update Data Here

      return ret;
    }
    #endregion

    #region Delete Method
    public int Delete(Employee entity)
    {
      int ret = 0;

      // TODO: Delete Data Here

      return ret;
    }
    #endregion

    #region Mock Data
    protected virtual ObservableCollection<Employee> GetEmployeeMocks()
    {
      Employee entity;
      ObservableCollection<Employee> ret = new ObservableCollection<Employee>();

      entity = new Employee();
      entity.EmployeeNumber = 1;
      entity.FirstName = "(Mock) John";
      entity.LastName = "(Mock) Doe";
      entity.SSN = "(Mock) 111-11-1111";
      ret.Add(entity);

      entity = new Employee();
      entity.EmployeeNumber = 2;
      entity.FirstName = "(Mock) Sally";
      entity.LastName = "(Mock) Smith";
      entity.SSN = "(Mock) 222-22-2222";
      ret.Add(entity);

      entity = new Employee();
      entity.EmployeeNumber = 3;
      entity.FirstName = "(Mock) Bill";
      entity.LastName = "(Mock) Jones";
      entity.SSN = "(Mock) 333-33-3333";
      ret.Add(entity);

      return ret;
    }
    #endregion
  }
}
