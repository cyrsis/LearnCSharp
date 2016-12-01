using System;
using System.Collections.Generic;

namespace ObserverDemo
{
    public class Doer
    {

        public MulticastNotifier<string> AfterDoSometihngWith;
        public MulticastNotifier<Tuple<string, string>> AfterDoMore;

        private string data = string.Empty;

        public void DoSomethingWith(string data)
        {
            this.data = data;
            OnAfterDoSomethingWith(this.data);
        }

        public void DoMore(string appendData)
        {
            this.data += appendData;
            OnAfterDoMore(this.data, appendData);
        }

        private void OnAfterDoSomethingWith(string data)
        {
            if (this.AfterDoSometihngWith != null)
                this.AfterDoSometihngWith.Notify(this, data);
        }

        private void OnAfterDoMore(string completeData, string appendedData)
        {
            if (this.AfterDoMore != null)
                this.AfterDoMore.Notify(this, Tuple.Create(completeData, appendedData));
        }
        
    }
}
