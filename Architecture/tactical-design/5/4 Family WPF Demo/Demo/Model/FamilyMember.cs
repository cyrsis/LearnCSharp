using Common;
using System.Drawing;

namespace Demo.Model
{
    public class FamilyMember
    {

        private ChainElement chain;

        public FamilyMember(ChainElement chain)
        {
            this.chain = chain;
        }

        public T As<T>(T defaultValue) where T : class
        {
            return this.chain.As<T>(defaultValue);
        }
    
    }
}
