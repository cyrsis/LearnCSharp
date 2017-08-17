using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace CommandHandling
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            CommandBinding copyCommand = new CommandBinding(ApplicationCommands.Copy);

            this.CommandBindings.Add(copyCommand);

            copyCommand.Executed += new ExecutedRoutedEventHandler(copyCommand_Executed);
        }

        void copyCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("Copy executed");
        }
    }
}
