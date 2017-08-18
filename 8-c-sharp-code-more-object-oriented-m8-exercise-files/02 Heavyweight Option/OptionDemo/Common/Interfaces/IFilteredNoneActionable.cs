using System;

namespace OptionDemo.Common.Interfaces
{
    public interface IFilteredNoneActionable<T>
    {
        IActionable<T> Do(Action action);
    }
}