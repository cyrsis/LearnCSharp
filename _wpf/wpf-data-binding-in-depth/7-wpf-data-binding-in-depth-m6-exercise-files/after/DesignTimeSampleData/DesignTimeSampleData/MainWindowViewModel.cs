using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zza.Data;

namespace DesignTimeSampleData
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            if (!DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
            {
                Customers = new ObservableCollection<Customer>
                {
                    new Customer { Id = Guid.NewGuid(), FirstName = "Brian", LastName = "Noyes", Phone = "555-555-5555", Email = "brian.noyes@solliance.net" },
                    new Customer { Id = Guid.NewGuid(), FirstName = "Fred", LastName = "Flintstone", Phone = "888-888-8888", Email = "fred.flintstone@solliance.net" }
                };
            }
        }
        private ObservableCollection<Customer> _Customers;
        public ObservableCollection<Customer> Customers
        {
            get
            {
                return _Customers;
            }
            set
            {
                _Customers = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Customers"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
