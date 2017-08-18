using PersonRepository.Interface;
using System;
using System.Configuration;

namespace Factory.RepositoryFactory
{
    public static class RepositoryFactory
    {
        public static IPersonRepository GetPersonRepository()
        {
            string repoTypeName = ConfigurationManager.AppSettings["RepositoryType"];
            Type repoType = Type.GetType(repoTypeName);
            object repoInstance = Activator.CreateInstance(repoType);
            IPersonRepository repo = repoInstance as IPersonRepository;
            return repo;
        }
    }
}
