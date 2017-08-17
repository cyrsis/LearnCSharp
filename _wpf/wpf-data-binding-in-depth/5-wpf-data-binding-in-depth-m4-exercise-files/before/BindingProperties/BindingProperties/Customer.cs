using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BindingProperties
{
    public class Customer : INotifyPropertyChanged
    {
        private bool _PremiumCustomer;
        private int _Age;
        private string _Phone = "555-555-5555";
        private string _Name;
        private int _Id;
        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (value != _Id)
                {
                    _Id = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Id"));
                }
                
            }
        }
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value != _Name)
                {
                    _Name = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }
        public string Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                if (value != _Phone)
                {
                    _Phone = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Phone"));
                }
            }
        }
        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                if (value != _Age)
                {
                    _Age = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Age"));
                }
            }
        }

        public bool PremiumCustomer
        {
            get
            {
                return _PremiumCustomer;
            }
            set
            {
                if (value != _PremiumCustomer)
                {
                    _PremiumCustomer = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("PremiumCustomer"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
