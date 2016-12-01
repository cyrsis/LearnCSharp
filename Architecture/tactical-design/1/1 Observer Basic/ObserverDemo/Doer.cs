using System;
using System.Collections.Generic;

namespace ObserverDemo
{
    public class Doer: ISubject
    {

        private IList<IObserver> observers = new List<IObserver>();

        private string data = string.Empty;

        public void DoSomethingWith(string data)
        {
            this.data = data;
            this.AfterDoSomethingWith(this.data);
        }

        public void DoMore(string appendData)
        {
            this.data += appendData;
            this.AfterDoMore(this.data, appendData);
        }

        public void AfterDoSomethingWith(string data)
        {
            foreach (IObserver observer in this.observers)
                observer.AfterDoSomethingWith(this, data);
        }

        public void AfterDoMore(string completeData, string appendedData)
        {
            foreach (IObserver observer in this.observers)
                observer.AfterDoMore(this, completeData, appendedData);
        }

        public void Attach(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this.observers.Remove(observer);
        }
    }
}
