using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace VSMHideShow
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public bool IsCollapsed
        {
            get { return (bool)GetValue(IsCollapsedProperty); }
            set { SetValue(IsCollapsedProperty, value); }
        }

        public static readonly DependencyProperty IsCollapsedProperty =
            DependencyProperty.Register("IsCollapsed", typeof(bool),
            typeof(MainWindow), new PropertyMetadata(false));

        public void ToggleIsCollapsed()
        {
            IsCollapsed = !IsCollapsed;
        }   
    }
}
