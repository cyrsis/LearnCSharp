﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Zza.Data;

namespace DataGrids
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var statesStr = "AL,AK,AZ,AR,CA,CO,CT,DE,FL,GA,HI,ID,IL,IN,IA,KS,KY,LA,ME,MD,MA,MI,MN,MS,MO,MT,NE,NV,NH,NJ,NM,NY,NC,ND,OH,OK,OR,PA,RI,SC,SD,TN,TX,UT,VT,VA,WA,WV,WI,WY";
            States = statesStr.Split(',').ToList();
            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                using (ZzaDbContext context = new ZzaDbContext())
                {
                    Customers = new ObservableCollection<Customer>(context.Customers.Include("Orders").ToList());
                }
            }
        }

        public ObservableCollection<Customer> Customers
        {
            get { return (ObservableCollection<Customer>)GetValue(CustomersProperty); }
            set { SetValue(CustomersProperty, value); }
        }

        public static readonly DependencyProperty CustomersProperty =
            DependencyProperty.Register("Customers", typeof(ObservableCollection<Customer>), typeof(MainWindow), new PropertyMetadata(null));

        public List<string> States
        {
            get { return (List<string>)GetValue(StatesProperty); }
            set { SetValue(StatesProperty, value); }
        }

        public static readonly DependencyProperty StatesProperty =
            DependencyProperty.Register("States", typeof(List<string>), typeof(MainWindow), new PropertyMetadata(null));

    }
}
