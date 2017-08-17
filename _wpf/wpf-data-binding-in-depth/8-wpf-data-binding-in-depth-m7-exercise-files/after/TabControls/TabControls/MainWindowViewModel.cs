using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabControls
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<ProductViewModel> _ChildViewModels;

        public MainWindowViewModel()
        {
            ChildViewModels = new ObservableCollection<ProductViewModel>
            {
                new ProductViewModel("pizza"),
                new ProductViewModel("salad"),
                new ProductViewModel("drink")
            };
        }
        public ObservableCollection<ProductViewModel> ChildViewModels
        {
            get
            {
                return _ChildViewModels;
            }
            set
            {
                if (value != _ChildViewModels)
                {
                    _ChildViewModels = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("ChildViewModels"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
