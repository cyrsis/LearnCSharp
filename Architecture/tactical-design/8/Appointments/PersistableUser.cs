using System;

namespace Appointments
{
    class PersistableUser: IRegistrantUser, IUserVisitor
    {

        private readonly IUser user;
        private readonly IRegistrationService registrationService;
        private string userName;
        private string password;

        public PersistableUser(IUser user, IRegistrationService registrationService,
                               string password)
        {
            this.user = user;
            this.registrationService = registrationService;
            this.password = password;

            this.user.Accept(() => this);

        }

        public IAppointment MakeAppointment(DateTime startTime)
        {
            return this.user.MakeAppointment(startTime);
        }

        public void Register()
        {
            this.registrationService.Register(this.userName, this.password);
        }

        public void ChangePassword(string newPassword)
        {
            this.registrationService.ChangePassword(this.userName, this.password,
                                                    newPassword);
            this.password = newPassword;
        }

        public void Accept(Func<IUserVisitor> visitorFactory)
        {
            this.user.Accept(visitorFactory);
        }

        public void VisitUser(string name)
        {
            this.userName = name;
        }

        public override string ToString()
        {
            return string.Format("PersistableUser(name={0}, password={1})",
                                 this.userName, this.password);
        }
    }
}
