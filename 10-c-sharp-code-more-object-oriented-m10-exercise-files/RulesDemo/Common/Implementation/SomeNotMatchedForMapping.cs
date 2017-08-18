using System;
using Demo.Common.Interfaces;

namespace Demo.Common.Implementation
{
    internal class SomeNotMatchedForMapping<T, TResult>: IFilteredMapped<T, TResult>
    {
        private T Value;

        public SomeNotMatchedForMapping(T value)
        {
            this.Value = value;
        }

        public IMapped<T, TResult> MapTo(Func<T, TResult> mapping) =>
            new MappingOnSomeNotResolved<T, TResult>(this.Value);
    }
}