using Common;
using System.Collections.Generic;

namespace TextDemo
{
    public class FamilyMember
    {

        readonly ChainElement components;

        public FamilyMember(ChainElement components)
        {
            this.components = components;
        }

        public T As<T>(T defaultValue) where T : class
        {
            return this.components.As<T>(defaultValue);
        }

    }
}
