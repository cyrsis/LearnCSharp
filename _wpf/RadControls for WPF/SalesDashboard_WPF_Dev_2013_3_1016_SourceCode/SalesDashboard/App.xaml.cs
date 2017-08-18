﻿using System;
using System.Windows;

namespace SalesDashboard
{
    public partial class App : Application
    {
#if !SILVERLIGHT
        public App()
        {
            //this.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
            this.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
            
            this.InitializeComponent();

            this.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("/SalesDashboard;component/Styles/WPF/RadGridViewScrollViewerStyle.xaml", UriKind.RelativeOrAbsolute) });
        }
#else
        public App()
        {
            this.Startup += this.Application_Startup;
            this.UnhandledException += this.Application_UnhandledException;
        
            InitializeComponent();

            this.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("/SalesDashboard;component/Styles/SL/RadGridViewScrollViewerStyle.xaml", UriKind.RelativeOrAbsolute) });

        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            this.RootVisual = new MainPage();
        }

        private void Application_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            // If the app is running outside of the debugger then report the exception using
            // the browser's exception mechanism. On IE this will display it a yellow alert 
            // icon in the status bar and Firefox will display a script error.
            if (!System.Diagnostics.Debugger.IsAttached)
            {

                // NOTE: This will allow the application to continue running after an exception has been thrown
                // but not handled. 
                // For production applications this error handling should be replaced with something that will 
                // report the error to the website and stop the application.
                e.Handled = true;
                Deployment.Current.Dispatcher.BeginInvoke(delegate { ReportErrorToDOM(e); });
            }
        }

        private void ReportErrorToDOM(ApplicationUnhandledExceptionEventArgs e)
        {
            try
            {
                string errorMsg = e.ExceptionObject.Message + e.ExceptionObject.StackTrace;
                errorMsg = errorMsg.Replace('"', '\'').Replace("\r\n", @"\n");

                System.Windows.Browser.HtmlPage.Window.Eval("throw new Error(\"Unhandled Error in Silverlight Application " + errorMsg + "\");");
            }
            catch (Exception)
            {
            }
        }
#endif
    }
}