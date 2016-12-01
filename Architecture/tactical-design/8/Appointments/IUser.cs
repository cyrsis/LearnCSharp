using System;

namespace Appointments
{
    interface IUser
    {
        IAppointment MakeAppointment(DateTime startTime);
        void Accept(Func<IUserVisitor> visitorFactory);
    }
}
