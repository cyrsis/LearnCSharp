using PropertyChanged;

namespace DemoWpfApplication
{
    [ImplementPropertyChanged]
    internal class MainViewModel
    {
        public string FirstName
        {
            get;
            set;
        }

        [DoNotNotify]
        public string LastName
        {
            get;
            set;
        }

        public string Initials
        {
            get
            {
                return FirstName.Substring(0, 1) + LastName.Substring(0, 1);
            }
        }
    }
}
