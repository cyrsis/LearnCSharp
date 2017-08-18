using System;

namespace Demo.Common.Interfaces
{
    public interface IFilteredActionable<T>
    {
        IActionable<T> Do(Action<T> action);
    }
}