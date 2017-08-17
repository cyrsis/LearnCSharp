﻿using System;
using System.Threading;

namespace DemoCode
{
    public class MemoryCalculator : IDisposable
    {
        public int CurrentValue { get; private set; }

        public void Add(int number)
        {
            CurrentValue += number;
        }

        public void Subtract(int number)
        {
            CurrentValue -= number;
        }

        public void Divide(int number)
        {
            CurrentValue = CurrentValue / number;
        }

        public void Clear()
        {
            CurrentValue = 0;
        }

        public void Dispose()
        {
            // Clean up resources
        }
    }
}
