using System;

namespace Appointments
{
    class User: IUser
    {

        private readonly string name;

        public User(string name)
        {
            this.name = name;
        }

        public IAppointment MakeAppointment(DateTime startTime)
        {
            return new Meeting(startTime, TimeSpan.FromHours(1));
        }

        public override string ToString()
        {
            return string.Format("User(name={0})", this.name);
        }

        public void Accept(Func<IUserVisitor> visitorFactory)
        {
            visitorFactory().VisitUser(this.name);
        }
    }
}
