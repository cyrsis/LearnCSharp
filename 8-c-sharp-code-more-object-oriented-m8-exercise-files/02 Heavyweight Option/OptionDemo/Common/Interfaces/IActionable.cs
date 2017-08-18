using System;

namespace OptionDemo.Common.Interfaces
{
    public interface IActionable<T>
    {
        IFilteredActionable<T> When(Func<T, bool> predicate);
        IFilteredActionable<T> WhenSome();
        IFilteredNoneActionable<T> WhenNone();
        void Execute();
    }
}