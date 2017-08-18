using System;

namespace OptionDemo.Common.Interfaces
{
    public interface IFiltered<T>: IFilteredActionable<T>
    {
        IMapped<T, TResult> MapTo<TResult>(Func<T, TResult> mapping);
    }
}