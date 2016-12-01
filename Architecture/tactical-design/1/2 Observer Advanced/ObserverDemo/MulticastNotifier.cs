using System.Collections.Generic;

namespace ObserverDemo
{
    public class MulticastNotifier<T>
    {
        
        private IList<IObserver<T>> invocationList;
        private IObserver<T> observer;

        private MulticastNotifier(IObserver<T> observer)
        {
            this.invocationList = new List<IObserver<T>>();
            this.invocationList.Add(observer);
        }

        private MulticastNotifier(MulticastNotifier<T> notifier, IObserver<T> observer)
        {
            this.invocationList = new List<IObserver<T>>(notifier.invocationList);
            this.invocationList.Add(observer);
        }

        public void Notify(object sender, T data)
        {
            foreach (IObserver<T> observer in this.invocationList)
                observer.Update(sender, data);
        }

        public static MulticastNotifier<T> operator + (MulticastNotifier<T> notifier, IObserver<T> observer)
        {
            if (notifier == null)
                return new MulticastNotifier<T>(observer);
            return new MulticastNotifier<T>(notifier, observer);
        }

    }
}
