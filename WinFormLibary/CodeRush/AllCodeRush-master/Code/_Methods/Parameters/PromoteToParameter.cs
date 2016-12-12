using System;
using System.Net.Mail;

namespace AllCodeRush.Code.Methods.Parameters
{
  /* •———————————————————————————————————————————————————————•
      Feature: Promote To Parameter
        
      Use Case: Helps you remove all references to a field or 
      a local declaration from the method, replacing it with a 
      parameter.
         
      Available: When the caret is on a local variable name 
      within the variable declaration statement, or inside a 
      primitive. 
        
      See also: Promote to Parameter (Optional), 
      Introduce Local
     •———————————————————————————————————————————————————————• */

  public class PromoteToParameter
	{
    private const string STR_SmtpServer = "smtp.google.com";
    private const string STR_SalesEmail = "sales@acme.com";
    private const string STR_DearCustomer = "Dear {0},";


    private static string GetDefaultBody()
    {
      return "It has been a while since we have heard from you. " +
                            "Don't let that pesky road runner get the best of you! " +
                            "Stop by our web site for a special promotion!";
    }
    public static void Send()
    {
      string customerEmail = "wile.e.coyote@looneytunes.com";
      MailMessage mail = new MailMessage(STR_SalesEmail, customerEmail);
      using (SmtpClient client = new SmtpClient())
      {
        client.Port = 25;
        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        client.UseDefaultCredentials = false;
        client.Host = STR_SmtpServer;

        mail.Subject = "New Traps Available!";

        string greeting = String.Format(STR_DearCustomer, "Mr. Coyote");
        string body = GetDefaultBody();
        string signature = "Yours truly, " + Environment.NewLine + "Acme Sales Team";

        mail.Body = greeting + Environment.NewLine + body + Environment.NewLine + signature;
        client.Send(mail);
      }
    }


		public void main()
		{
			Send();
		}
	}
}
