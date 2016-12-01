using System;

namespace Appointments
{
    class DataService: IRegistrationService
    {
        public void Register(string name, string password)
        {
            Console.WriteLine(
                "INSERT INTO User (UserName, Password)\n" +
                "VALUES ('{0}', '{1}')\n", name, password);
        }

        public void ChangePassword(string name, string password, string newPassword)
        {
            Console.WriteLine(
                "UPDATE User SET Password='{0}'\n" +
                "WHERE UserName='{1}' AND Password='{2}'\n",
                newPassword, name, password);
        }
    }
}
