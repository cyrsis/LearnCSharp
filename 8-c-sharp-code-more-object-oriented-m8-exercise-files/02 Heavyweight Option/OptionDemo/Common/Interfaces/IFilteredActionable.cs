using System;

namespace OptionDemo.Common.Interfaces
{
    public interface IFilteredActionable<T>
    {
        IActionable<T> Do(Action<T> action);
    }
}