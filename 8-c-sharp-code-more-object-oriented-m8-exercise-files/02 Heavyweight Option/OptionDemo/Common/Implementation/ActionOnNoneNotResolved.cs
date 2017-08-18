﻿using System;
using OptionDemo.Common.Interfaces;

namespace OptionDemo.Common.Implementation
{
    internal class ActionOnNoneNotResolved<T>: IActionable<T>
    {
        public IFilteredActionable<T> When(Func<T, bool> predicate) =>
            new NoneNotMatchedAsSome<T>();

        public IFilteredActionable<T> WhenSome() =>
            new NoneNotMatchedAsSome<T>();

        public IFilteredNoneActionable<T> WhenNone() =>
            new NoneMatched<T>();

        public void Execute() { }

    }
}