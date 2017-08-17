using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace DataGrid
{
   public class Employee : INotifyPropertyChanged
   {
      private string _name;
      public string Name
      {
         get { return _name; }
         set
         {
            _name = value;
            RaisePropertyChanged();
         }
      }
      private string _title;
      public string Title
      {
         get { return _title; }
         set
         {
            _title = value;
            RaisePropertyChanged();
         }
      }

      private bool _wasReelected;
      public bool WasReelected
      {
         get
         {
            return _wasReelected;
         }
         set
         {
            _wasReelected = value;
            RaisePropertyChanged();

         }
      }


      private Party _affiliation;
      public Party Affiliation
      {
         get
         {
            return _affiliation;
         }
         set
         {
            _affiliation = value;
            RaisePropertyChanged();

         }
      }

      public static ObservableCollection<Employee> GetEmployees()
      {
         var employees = new ObservableCollection<Employee>();
         employees.Add( new Employee() { Name = "Washington", Title = "President 1", WasReelected = true, Affiliation = Party.Independent } );
         employees.Add( new Employee() { Name = "Adams", Title = "President 2", WasReelected = false, Affiliation = Party.Federalist } );
         employees.Add( new Employee() { Name = "Jefferson", Title = "President 3", WasReelected = true, Affiliation = Party.DemocratRepublican } );
         employees.Add( new Employee() { Name = "Madison", Title = "President 4", WasReelected = true, Affiliation = Party.DemocratRepublican } );
         employees.Add( new Employee() { Name = "Monroe", Title = "President 5", WasReelected = true, Affiliation = Party.DemocratRepublican } );
         return employees;
      }


      public event PropertyChangedEventHandler PropertyChanged;

      private void RaisePropertyChanged(
          [CallerMemberName] string caller = "" )
      {
         if ( PropertyChanged != null )
         {
            PropertyChanged( this, new PropertyChangedEventArgs( caller ) );
         }
      }

   }

   public enum Party
   {
      Independent,
      Federalist,
      DemocratRepublican,
   }


}
