using System;

namespace Appointments
{
    interface IUserGroup
    {
        void AddMember(IUser user);
        void Accept(Func<IUserGroupVisitor> visitorFactory);
    }
}
