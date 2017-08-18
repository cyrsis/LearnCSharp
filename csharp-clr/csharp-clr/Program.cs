using System;
using MessengerAPI;


namespace csharp_clr
{    
    static class Program
    {
        static void Main()
        {
            Messenger messenger  = new Messenger();
            messenger.OnContactStatusChange += new DMessengerEvents_OnContactStatusChangeEventHandler(messenger_OnContactStatusChange);
            Console.ReadLine();
        }

        static void messenger_OnContactStatusChange(dynamic contact, MISTATUS mStatus)
        {
            Console.WriteLine(contact.FriendlyName + " " + mStatus.ToString()); 
        }           
    }
}


