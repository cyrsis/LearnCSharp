using System.Threading.Tasks;

namespace Cubo.Core.Services
{
    public interface IDataInitializer
    {
         Task SeedAsync();
    }
}