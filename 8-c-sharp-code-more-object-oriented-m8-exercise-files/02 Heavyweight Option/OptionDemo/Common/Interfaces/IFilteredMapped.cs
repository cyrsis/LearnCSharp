using System;

namespace OptionDemo.Common.Interfaces
{
    public interface IFilteredMapped<T, TResult>
    {
        IMapped<T, TResult> MapTo(Func<T, TResult> mapping);
    }
}