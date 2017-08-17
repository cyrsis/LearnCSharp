using System;

namespace Demo
{
    public class Diary
    {
        public DateTime Yesterday
        {
            get
            {
                return DateTime.Now.Subtract(TimeSpan.FromDays(1));
            }
        }
    }
}
