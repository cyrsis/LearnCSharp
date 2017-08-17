using System;
using Janitor;

namespace Demo
{
    [SkipWeaving]
    public class ManuallyImplemented : IDisposable
    {
        public string SomeProperty { get; set; }

        public void Dispose()
        {
            // Automatically called by Janitor
        }
    }
}