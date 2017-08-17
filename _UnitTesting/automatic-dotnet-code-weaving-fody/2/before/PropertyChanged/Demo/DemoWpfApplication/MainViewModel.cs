using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DemoWpfApplication
{
    class MainViewModel : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (value == _firstName)
                {
                    return;
                }

                _firstName = value;

                OnPropertyChanged();
                OnPropertyChanged("Initials");
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value == _lastName)
                {
                    return;
                }

                _lastName = value;

                OnPropertyChanged();
                OnPropertyChanged("Initials");
            }
        }

        public string Initials
        {
            get
            {
                return FirstName.Substring(0, 1) + LastName.Substring(0, 1);
            }
        }
       

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
