using System;
using OptionDemo.Common.Interfaces;

namespace OptionDemo.Common.Implementation
{
    internal class NoneMatchedForMapping<T, TResult>: IFilteredNoneMapped<T, TResult>
    {
        public IMapped<T, TResult> MapTo(Func<TResult> mapping) =>
            new MappingResolved<T, TResult>(mapping());
    }
}