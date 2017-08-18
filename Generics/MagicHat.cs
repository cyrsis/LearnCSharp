using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    class MagicHat<T> where T: class, IAmMagical, new()
    {
        public void Fill()
        {
            for (int i = 0; i < 5; i++)
            {
                T newThing = new T();
                _queue.Enqueue(newThing);
            }
        }

        public void Dissapear()
        {
            while (_queue.Count > 0)
            {
                T thing = _queue.Dequeue();
                thing.Dissapear();
            }
        }

        public void Put(T newThing)
        {
            if (newThing != null)
            {
                _queue.Enqueue(newThing);
            }
        }

        public T Pull()
        {
            if (_queue.Count == 0)
            {
                return null;
            }

            return _queue.Dequeue();
        }

        Queue<T> _queue = new Queue<T>();
    }
}
