using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Accessors
{
    class SingleWatcher
    {
        private EventHandler TheWatcher = null;

        public event EventHandler SingleEvent
        {
            add { TheWatcher = value; }
            remove { TheWatcher -= value; }
        }

        public void OnSingleEvent()
        {
            if (TheWatcher != null) TheWatcher(this, null);
        }
    }
}
