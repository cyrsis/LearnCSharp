using System;
using Demo.Common.Interfaces;

namespace Demo.Common.Implementation
{
    internal class NoneNotMatchedAsSome<T>: IFiltered<T>
    {
        public IActionable<T> Do(Action<T> action) =>
            new ActionOnNoneNotResolved<T>();

        public IMapped<T, TResult> MapTo<TResult>(Func<T, TResult> mapping) =>
            new MappingOnNoneNotResolved<T, TResult>();

    }
}