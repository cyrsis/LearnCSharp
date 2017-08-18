using System;

namespace OptionDemo.Common.Interfaces
{
    public interface IFilteredNoneMapped<T, TResult>
    {
        IMapped<T, TResult> MapTo(Func<TResult> mapping);
    }
}