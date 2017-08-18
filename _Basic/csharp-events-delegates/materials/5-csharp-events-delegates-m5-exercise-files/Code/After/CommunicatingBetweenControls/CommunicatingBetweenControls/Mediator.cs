using CommunicatingBetweenControls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicatingBetweenControls
{
    public sealed class Mediator
    {
        //Singleton functionality
        private static readonly Mediator _Instance = new Mediator();
        private Mediator() { }

        public static Mediator GetInstance()
        {
            return _Instance;
        }

        //Instance functionality
        public event EventHandler<JobChangedEventArgs> JobChanged;

        public void OnJobChanged(Object sender, Job job)
        {
            var jobChangeDelegate = JobChanged as EventHandler<JobChangedEventArgs>;
            if (jobChangeDelegate != null)
            {
                jobChangeDelegate(sender, new JobChangedEventArgs { Job = job });
            }
        }

    }
}
