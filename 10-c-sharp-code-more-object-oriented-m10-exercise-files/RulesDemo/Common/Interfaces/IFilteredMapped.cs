using System;

namespace Demo.Common.Interfaces
{
    public interface IFilteredMapped<T, TResult>
    {
        IMapped<T, TResult> MapTo(Func<T, TResult> mapping);
    }
}