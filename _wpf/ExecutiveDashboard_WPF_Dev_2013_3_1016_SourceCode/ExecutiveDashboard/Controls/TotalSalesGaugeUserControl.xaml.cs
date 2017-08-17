using System;
using System.Linq;
using System.Windows.Controls;

namespace ExecutiveDashboard
{
    public partial class TotalSalesGaugeUserControl : UserControl
    {
        public TotalSalesGaugeUserControl()
        {
            InitializeComponent();
        }
#if !SILVERLIGHT
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            var vm = this.DataContext as ViewModel;
            if (vm != null)
            {
                vm.PropertyChanged += OnDataContextPropertyChanged;
            }
        }

        private void OnDataContextPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "SelectedActualTotalSalesAmount")
            {
                this.radialBar.Visibility = System.Windows.Visibility.Collapsed;
                this.radialBar.Visibility = System.Windows.Visibility.Visible;
            }
        }
#endif
    }
}
