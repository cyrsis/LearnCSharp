using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using Zza.Data;

namespace DataTemplates
{
    public class HierachicalDataTemplatesViewModel : INotifyPropertyChanged
    {
        public HierachicalDataTemplatesViewModel()
        {
            if (!DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                using (ZzaDbContext context = new ZzaDbContext())
                {
                    Customers = new ObservableCollection<Customer>(
                        context.Customers.Include("Orders")
                        .Include("Orders.OrderItems")
                        .Include("Orders.OrderItems.Product").ToList());
                }
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
