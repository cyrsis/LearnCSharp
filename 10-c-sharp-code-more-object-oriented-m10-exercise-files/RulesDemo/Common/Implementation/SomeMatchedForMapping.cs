using System;
using Demo.Common.Interfaces;

namespace Demo.Common.Implementation
{
    internal class SomeMatchedForMapping<T, TResult> : IFilteredMapped<T, TResult>
    {
        private T Value;

        public SomeMatchedForMapping(T value)
        {
            this.Value = value;
        }

        public IMapped<T, TResult> MapTo(Func<T, TResult> mapping) =>
            new MappingResolved<T, TResult>(mapping(this.Value));
    }
}