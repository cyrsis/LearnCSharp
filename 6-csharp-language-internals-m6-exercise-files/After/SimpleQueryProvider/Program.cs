using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SimpleQueryProvider
{
    class Program
    {
        static void Main()
        {
            var source = new MyQuery<string>();

            // Custom query provider implementation restricts
            // to only those operators we are able to support.

            var query = from x in source    // <-- should fail to compile
                        where x.Length > 0  //     ...
                        select x + "!";     //     unless #define SUPPORTSELECT

            foreach (var item in query)
            {
                // Process item
            }
        }
    }

    class MyQuery<T>
    {
        public MyQuery<T> Where(Expression<Func<T, bool>> f)
        {
            throw new NotImplementedException();
        }

#if SUPPORTSELECT
        public MyQuery<R> Select<R>(Expression<Func<T, R>> f)
        {
            throw new NotImplementedException();
        }
#endif

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public Expression Expression
        {
            get { throw new NotImplementedException(); }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
