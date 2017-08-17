using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Interactivity;
using System.Windows.Media;

namespace CustomBlendSDKBehaviorsDemo
{
    public class EmployeeTrigger : TriggerBase<TextBlock>
    {

        public string BossName
        {
            get { return (string)GetValue(BossNameProperty); }
            set { SetValue(BossNameProperty, value); }
        }

        public static readonly DependencyProperty BossNameProperty =
            DependencyProperty.Register("BossName", typeof(string), 
            typeof(EmployeeTrigger), new PropertyMetadata(null));


        protected override void OnAttached()
        {
            AssociatedObject.Loaded += OnLoaded;
            AssociatedObject.Unloaded += OnUnloaded;
        }

        protected override void OnDetaching()
        {
            AssociatedObject.Loaded -= OnLoaded;
            AssociatedObject.Unloaded -= OnUnloaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            AssociatedObject.DataContextChanged += OnDataContextChanged;
            Refresh();
        }

        private void OnUnloaded(object sender, RoutedEventArgs e)
        {
            AssociatedObject.DataContextChanged -= OnDataContextChanged;
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            Binding binding = BindingOperations.GetBinding(AssociatedObject, TextBlock.TextProperty);
            if (binding != null)
            {
                // Binding source object can come from DataContext, Source, RelativeSource, or ElementName
                // This just handles DataContext bindings...
                if (binding.Source == null && binding.ElementName == null && binding.RelativeSource == null && AssociatedObject.DataContext != null)
                {
                    Employee emp = AssociatedObject.DataContext as Employee;
                    if (emp != null && emp.Boss != null && emp.Boss == BossName)
                    {
                        base.InvokeActions(null);
                    }
                }

            }
        }
    }
}
