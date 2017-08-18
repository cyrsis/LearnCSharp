using System;
using System.Net;

namespace csharp_func
{
    public static class Extensions
    {
        public static T WithRetry<T>(this Func<T> action)
        {
            var result = default(T);
            int retryCount = 0;

            bool succesful = false;
            do
            {
                try
                {
                    result = action();
                    succesful = true;
                }
                catch (WebException ex)
                {
                    retryCount++;
                }
            } while (retryCount < 3 && !succesful);
            
            return result;
        }

        public static Func<TResult> Partial<TParam1, TResult>(
            this Func<TParam1, TResult> func, TParam1 parameter)
        {
            return () => func(parameter);            
        }

        public static Func<TParam1, Func<TResult>> Curry<TParam1, TResult>
            (this Func<TParam1, TResult> func)
        {
            return parameter => () => func(parameter);
        }
    }   
}