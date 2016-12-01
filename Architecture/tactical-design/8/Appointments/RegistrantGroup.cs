using System;
using System.Collections.Generic;

namespace Appointments
{
    class RegistrantGroup: IRegistrantGroup, IUserGroupVisitor
    {
        private IUserGroup group;
        private string groupName;
        private string password;

        public RegistrantGroup(IUserGroup group, string groupName, string password)
        {
            this.group = group;
            this.groupName = groupName;
            this.password = password;
        }

        public void AddMember(IUser user)
        {
            this.group.AddMember(user);
        }

        public void Register()
        {
            Console.WriteLine("Registering group '{0}' with password '{1}'.",
                              this.groupName, this.password);
            this.group.Accept(() => this);
        }

        public void ChangePassword(string newPassword)
        {
            Console.WriteLine("Changing '{0}' group password from '{1}' to '{2}'.",
                              this.groupName, this.password, newPassword);
            this.password = newPassword;
        }

        public void Accept(Func<IUserGroupVisitor> visitorFactory)
        {
            this.group.Accept(visitorFactory);
        }

        public void VisitUser(string name)
        {
            Console.WriteLine("\tAssociating {0} with group '{1}'",
                              name, this.groupName);
        }
    }
}
