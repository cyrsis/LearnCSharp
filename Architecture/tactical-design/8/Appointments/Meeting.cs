using System;

namespace Appointments
{
    class Meeting: IAppointment
    {

        private readonly DateTime startTime;
        private readonly TimeSpan duration;

        public Meeting(DateTime startTime, TimeSpan duration)
        {
            this.startTime = startTime;
            this.duration = duration;
        }

        public override string ToString()
        {
            return string.Format("Meeting starting at {0}, taking {1} min.",
                                 this.startTime, (int)this.duration.TotalMinutes);
        }
    }
}
