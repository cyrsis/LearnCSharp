using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace AllCodeRush.Code.Methods.Parameters
{
  /* •———————————————————————————————————————————————————————•
      Feature: Decompose Parameter
        
      Use Case: Lets you replace a single parameter with one or 
      more new parameters, each representing a property accessed 
      in the original parameter. And appropriately changes all 
      method references.
         
      Available:  
       - When the caret is on a declaration for a parameter 
         that is exclusively used to reference its properties 
         in the method body.
       - When the caret is on a reference to a property of a 
         parameter.
        
      See also: Introduce Parameter Object
     •———————————————————————————————————————————————————————• */
  public class Email
  {
    public static string Signature { get; set; }
    public static void Send(Customer customer, string subject, string body)
    {
      MailMessage mail = new MailMessage("coyote@acme.com", customer.Email);
      using (SmtpClient client = new SmtpClient())
      {
        client.Port = 25;
        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        client.UseDefaultCredentials = false;
        client.Host = "smtp.google.com";
        mail.Subject = subject;
        mail.Body = String.Format("Dear {0},", customer.Name) + Environment.NewLine + 
                    body + Environment.NewLine + 
                    Signature;
        client.Send(mail);
      }
    }
  }

	public class DecomposeParameter
	{
    public void MailMerge(List<Customer> customers, string subject, string body)
		{
      foreach (Customer customer in customers)
        if (OldEnough(customer))
          Email.Send(customer, subject, body);
		}

    private bool OldEnough(Customer customer)
    {
      return customer.Age >= 21;
    }
	}
}