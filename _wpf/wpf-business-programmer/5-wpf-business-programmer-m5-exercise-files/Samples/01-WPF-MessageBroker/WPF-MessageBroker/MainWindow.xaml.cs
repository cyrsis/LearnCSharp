using System.Windows;

using PDSA.MessageBroker;

namespace WPF_MessageBroker
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();

      // Initialize the Message Broker Events
      (Application.Current as App).MessageBroker.MessageReceived +=
        new MessageReceivedEventHandler(MessageBroker_MessageReceived);
    }

    void MessageBroker_MessageReceived(object sender, PDSAMessageBrokerEventArgs e)
    {
      switch (e.MessageName)
      {
        case "FromPage1":
          MessageBox.Show(e.Message.MessageBody.ToString());
          break;

        case "StatusBar":
          tbStatus.Text = e.Message.MessageBody.ToString();
          break;
      }
    }

    private void btnPage1_Click(object sender, RoutedEventArgs e)
    {
      ucPage1 uc = new ucPage1();

      contentArea.Children.Clear();
      contentArea.Children.Add(uc);
    }

    private void btnSendToPage1_Click(object sender, RoutedEventArgs e)
    {
      PDSAMessageBrokerMessage arg = new PDSAMessageBrokerMessage();

      arg.MessageName = "ForPage1";
      arg.MessageBody = "Message For Page 1";

      // Send a message to Page 1
      (Application.Current as App).MessageBroker.SendMessage(arg);
    }

    private void btnPage2_Click(object sender, RoutedEventArgs e)
    {
      ucPage2 uc = new ucPage2();

      contentArea.Children.Clear();
      contentArea.Children.Add(uc);
    }

    private void Window_Unloaded(object sender, RoutedEventArgs e)
    {
      // Unhook the event handler from the global message broker
      (Application.Current as App).MessageBroker.MessageReceived -=
        MessageBroker_MessageReceived;
    }
  }
}
