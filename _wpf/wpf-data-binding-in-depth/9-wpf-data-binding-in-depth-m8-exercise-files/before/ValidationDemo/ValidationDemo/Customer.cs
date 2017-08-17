using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ValidationDemo
{
    public class Customer : INotifyPropertyChanged
    {
        private string _HomePhone;
        public string HomePhone
        {
            get { return _HomePhone; }
            set
            {
                if (_HomePhone != value)
                {
                    _HomePhone = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("HomePhone"));
                }
            }
        }

        private string _WorkPhone = "999-999-9999";
        public string WorkPhone
        {
            get { return _WorkPhone; }
            set
            {
                if (_WorkPhone != value)
                {
                    _WorkPhone = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("WorkPhone"));
                }
            }
        }

        private string _CellPhone;
        public string CellPhone
        {
            get { return _CellPhone; }
            set
            {
                if (_CellPhone != value)
                {
                    _CellPhone = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("CellPhone"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
