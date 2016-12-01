using System.Collections.Generic;

namespace ConsoleFamily
{
    class FamilyMember
    {
        private readonly IEnumerable<object> parts;

        public FamilyMember(IEnumerable<object> parts)
        {
            this.parts = new List<object>(parts);
        }

        public T As<T>()
        {
            foreach (object obj in this.parts)
                if (obj is T)
                    return (T)obj;
            return default(T);
        }
    }
}
