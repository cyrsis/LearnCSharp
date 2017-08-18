using System;

namespace Demo.Common.Interfaces
{
    public interface IFilteredNoneActionable<T>
    {
        IActionable<T> Do(Action action);
    }
}