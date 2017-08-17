using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplates
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private object _CurrentViewModel;
        ExplicitDataTemplatesViewModel _ViewModel1 = new ExplicitDataTemplatesViewModel();
        DataTemplateSelectorsViewModel _ViewModel2 = new DataTemplateSelectorsViewModel();
        HierachicalDataTemplatesViewModel _ViewModel3 = new HierachicalDataTemplatesViewModel();

        public MainWindowViewModel()
        {
            View1Command = new RelayCommand(ShowView1);
            View2Command = new RelayCommand(ShowView2);
            View3Command = new RelayCommand(ShowView3);
            CurrentViewModel = _ViewModel1;
        }
        public RelayCommand View1Command { get; set; }
        public RelayCommand View2Command { get; set; }
        public RelayCommand View3Command { get; set; }

        public object CurrentViewModel
        {
            get
            {
                return _CurrentViewModel;
            }
            set
            {
                _CurrentViewModel = value;
                PropertyChanged(this, new PropertyChangedEventArgs("CurrentViewModel"));
            }
        }

        private void ShowView1()
        {
            CurrentViewModel = _ViewModel1;
        }

        private void ShowView2()
        {
            CurrentViewModel = _ViewModel2;
        }

        private void ShowView3()
        {
            CurrentViewModel = _ViewModel3;
        }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
