using System;
using System.Collections.Generic;

namespace Appointments
{
    class Program
    {

        static void MassRegister(IEnumerable<IRegistrant> registrants)
        {
            foreach (IRegistrant registrant in registrants)
                registrant.Register();
        }

        static void ScramblePasswords(IEnumerable<IRegistrant> registrants)
        {
            foreach (IRegistrant registrant in registrants)
                registrant.ChangePassword(Guid.NewGuid().ToString().Substring(0, 6));
        }

        static void Main(string[] args)
        {

            DomainService domain =
                new DomainService(
                    new UserFactory(
                        new DataService()));

            IUser jill = new User("jill");
            IUser joe = new User("joe");
            IUser jack = new User("jack");

            IUserGroup group = new UserGroup();
            group.AddMember(jill);
            group.AddMember(joe);
            group.AddMember(jack);

            DataService dataSvc = new DataService();

            IEnumerable<IRegistrant> registrants =
                new IRegistrant[]
                {
                    new PersistableUser(jill, dataSvc, "pwd"),
                    new PersistableUser(jack, dataSvc, "pwd"),
                    new PersistableUser(joe, dataSvc, "pwd"),
                    new RegistrantGroup(group, "friends", "secret")
                };

            //MassRegister(registrants);
            ScramblePasswords(registrants);

            Console.ReadLine();

        }
    }
}
