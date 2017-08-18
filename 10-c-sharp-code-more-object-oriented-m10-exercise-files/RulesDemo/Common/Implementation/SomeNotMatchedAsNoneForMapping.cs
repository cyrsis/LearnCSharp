using System;
using Demo.Common.Interfaces;

namespace Demo.Common.Implementation
{
    internal class SomeNotMatchedAsNoneForMapping<T, TResult>: IFilteredNoneMapped<T, TResult>
    {
        private T Value { get; }

        public SomeNotMatchedAsNoneForMapping(T value)
        {
            this.Value = value;
        }

        public IMapped<T, TResult> MapTo(Func<TResult> mapping) =>
            new MappingOnSomeNotResolved<T, TResult>(this.Value);

    }
}