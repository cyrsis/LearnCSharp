using System;
using System.Configuration;

namespace Factory.RepositoryFactory
{
    public static class GenericFactory
    {
        public static T Get<T>() where T : class
        {
            throw new NotImplementedException();
        }
    }
}
