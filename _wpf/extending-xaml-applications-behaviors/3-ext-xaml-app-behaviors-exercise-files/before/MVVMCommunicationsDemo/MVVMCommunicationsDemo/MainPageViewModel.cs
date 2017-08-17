using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MVVMCommunicationsDemo
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            Customers = new ObservableCollection<Customer>
            {
                new Customer { Id = 1, Name = "Bart", Phone="5555555555" },
                new Customer { Id = 2, Name="Homer", Phone="99999999999" },
                new Customer { Id = 3, Name="Lisa", Phone="8888888888" },
            };
        }

        public ObservableCollection<Customer> Customers { get; set; }
        
    }
}
