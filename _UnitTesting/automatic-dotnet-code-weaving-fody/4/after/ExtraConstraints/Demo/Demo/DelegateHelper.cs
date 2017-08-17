using System;
using ExtraConstraints;

namespace Demo
{
    public class DelegateHelper<[DelegateConstraint(typeof(Action))] T>
    {
        public void ExecuteRandomDelegate(T d1, T d2)
        {
            Action a;

            if (DateTime.Now.Ticks % 2 == 0)
            {
                a = d1 as Action;
            }
            else
            {
                a = d2 as Action;
            }
            
            a();
        }
    }
}