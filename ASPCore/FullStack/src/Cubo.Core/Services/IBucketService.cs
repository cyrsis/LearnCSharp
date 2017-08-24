using System.Collections.Generic;
using System.Threading.Tasks;
using Cubo.Core.DTO;

namespace Cubo.Core.Services
{
    public interface IBucketService
    {
         Task<BucketDTO> GetAsync(string name);
         Task<IEnumerable<string>> GetNamesAsync();
         Task AddAsync(string name);
         Task RemoveAsync(string name);
    }
}