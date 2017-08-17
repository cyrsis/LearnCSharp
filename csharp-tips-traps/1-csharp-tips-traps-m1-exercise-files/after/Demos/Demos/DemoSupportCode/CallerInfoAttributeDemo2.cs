using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Demos.DemoSupportCode
{
    internal class CallerInfoAttributeDemo2 : INotifyPropertyChanged
    {
        private int _age;
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                // Without [CallerMemberName] we have to pass a string of the prop name
                OnPropertyChanged("Age");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                var eventArgs = new PropertyChangedEventArgs(propertyName);

                PropertyChanged(this, eventArgs);
            }
        }
    }
}