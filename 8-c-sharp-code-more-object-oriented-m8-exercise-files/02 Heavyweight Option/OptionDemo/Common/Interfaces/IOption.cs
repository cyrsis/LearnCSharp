using System;

namespace OptionDemo.Common.Interfaces
{
    public interface IOption<T>
    {
        IFiltered<T> When(Func<T, bool> predicate);
        IFiltered<T> WhenSome();
        IFilteredNone<T> WhenNone();
    }
}