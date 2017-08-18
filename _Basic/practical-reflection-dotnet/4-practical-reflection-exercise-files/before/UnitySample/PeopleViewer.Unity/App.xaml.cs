using PeopleViewer.Presentation;
using PersonRepository.CSV;
using PersonRepository.Interface;
using PersonRepository.Service;
using PersonRepository.SQL;
using System.Windows;
using Microsoft.Practices.Unity;

namespace PeopleViewer
{
    public partial class App : Application
    {
        IUnityContainer Container;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ConfigureContainer();
            ComposeObjects();
            Application.Current.MainWindow.Show();
        }

        private void ConfigureContainer()
        {
            Container = new UnityContainer();
            Container.RegisterType<IPersonRepository, ServiceRepository>(
                new ContainerControlledLifetimeManager());
        }

        private void ComposeObjects()
        {
            Application.Current.MainWindow = Container.Resolve<PeopleViewerWindow>();
            Application.Current.MainWindow.Title = "DI with Unity - People Viewer";
        }
    }
}
