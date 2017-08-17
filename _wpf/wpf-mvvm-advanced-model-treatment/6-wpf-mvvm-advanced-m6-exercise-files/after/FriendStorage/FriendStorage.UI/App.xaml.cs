using System.Windows;
using Autofac;
using FriendStorage.UI.Startup;
using FriendStorage.UI.View;
using FriendStorage.UI.ViewModel;
using FriendStorage.UI.View.Services;

namespace FriendStorage.UI
{
  public partial class App : Application
  {
    private MainViewModel _mainViewModel;

    protected override void OnStartup(StartupEventArgs e)
    {
      base.OnStartup(e);
      var bootstrapper = new Bootstrapper();
      IContainer container = bootstrapper.Bootstrap();

      _mainViewModel = container.Resolve<MainViewModel>();
      MainWindow = new MainWindow(_mainViewModel);
      MainWindow.Show();
      _mainViewModel.Load();
    }
  }
}
