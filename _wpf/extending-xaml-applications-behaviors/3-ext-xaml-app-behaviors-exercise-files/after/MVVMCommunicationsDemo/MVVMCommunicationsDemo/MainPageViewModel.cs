using Microsoft.Practices.Prism.StoreApps;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMCommunicationsDemo
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            SelectCustomerCommand = new DelegateCommand<Customer>(OnSelectCustomer);
            Customers = new ObservableCollection<Customer>
            {
                new Customer { Id = 1, Name = "Bart", Phone="5555555555" },
                new Customer { Id = 2, Name="Homer", Phone="99999999999" },
                new Customer { Id = 3, Name="Lisa", Phone="8888888888" },
            };
        }

        public ICommand SelectCustomerCommand { get; set; }

        public ObservableCollection<Customer> Customers { get; set; }

        private CustomerStatus _customerStatus;
        public CustomerStatus CustomerStatus
        {
            get
            {
                return _customerStatus;
            }
            set
            {
                _customerStatus = value;
            }
        }

        private void OnSelectCustomer(Customer customer)
        {

        }

        public void ViewLoaded()
        {

        }

        
    }
}
