using System.Windows;

namespace PDSA.WPF
{
  public class PDSAMessageBox
  {
    public static MessageBoxResult Show(string message)
    {
      return Show(message, string.Empty, MessageBoxButton.OK);
    }

    public static MessageBoxResult Show(string message, string caption)
    {
      return Show(message, caption, MessageBoxButton.OK);
    }

    public static MessageBoxResult Show(string message, string caption, MessageBoxButton buttons)
    {
      MessageBoxResult result = MessageBoxResult.None;
      PDSAMessageBoxView dialog = new PDSAMessageBoxView();

      dialog.Title = caption;
      dialog.tbMessage.Text = message;
      dialog.Buttons = buttons;
      // If just an OK button, allow the user to just move away from the dialog
      if (buttons == MessageBoxButton.OK)
        dialog.Show();
      else
      {
        dialog.ShowDialog();
        result = dialog.Result;
      }

      return result;
    }
  }
}
