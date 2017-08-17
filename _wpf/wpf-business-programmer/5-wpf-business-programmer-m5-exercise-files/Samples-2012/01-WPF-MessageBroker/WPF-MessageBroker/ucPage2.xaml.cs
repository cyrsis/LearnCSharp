using System.Windows;
using System.Windows.Controls;

using PDSA.MessageBroker;

namespace WPF_MessageBroker
{
  public partial class ucPage2 : UserControl
  {
    private Page2ViewModel _ViewModel;

    public ucPage2()
    {
      InitializeComponent();

      // Hook into View Model
      _ViewModel = (Page2ViewModel)this.Resources["viewModel"];
      // Hook into Global Message Broker
      (Application.Current as App).MessageBroker.MessageReceived += 
        new MessageReceivedEventHandler(MessageBroker_MessageReceived);
      // Pass in Message Broker to View Model
      _ViewModel.MessageBroker = (Application.Current as App).MessageBroker;
    }

    private void UserControl_Loaded(object sender, RoutedEventArgs e)
    {
      // Send Status Message
      (Application.Current as App).MessageBroker.
        SendMessage(new PDSAMessageBrokerMessage("StatusBar", "This is Page 2"));
    }

    void MessageBroker_MessageReceived(object sender, PDSAMessageBrokerEventArgs e)
    {
      switch (e.MessageName)
      {
        case "FromPage2ViewModel":
          MessageBox.Show(e.Message.MessageBody.ToString());
          break;
      }
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      _ViewModel.DoSomething();
    }

    private void UserControl_Unloaded(object sender, RoutedEventArgs e)
    {
      // You must get rid of any events from the view model
      _ViewModel.Dispose();
     
      (Application.Current as App).MessageBroker.MessageReceived -= 
        MessageBroker_MessageReceived;
    }
  }
}
