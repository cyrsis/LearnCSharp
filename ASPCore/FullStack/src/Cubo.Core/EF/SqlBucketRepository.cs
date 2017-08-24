using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cubo.Core.Domain;
using Cubo.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Cubo.Core.EF
{
    public class SqlBucketRepository : IBucketRepository
    {
        private readonly CuboContext _context;

        public SqlBucketRepository(CuboContext context)
        {
            _context = context;
        }

        public async Task<Bucket> GetAsync(string name)
        {
            var bucket = await _context.Buckets
                .Include(x => x.Items)
                .SingleOrDefaultAsync(x => x.Name == name);

            return bucket;
        }

        public async Task<IEnumerable<string>> GetNamesAsync()
        => await _context.Buckets.Select(x => x.Name).ToListAsync();

        public async Task AddAsync(Bucket bucket)
        {
            await _context.Buckets.AddAsync(bucket);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Bucket bucket)
        {
            _context.Buckets.Update(bucket);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(string name)
        {
            var bucket = await GetAsync(name);
            _context.Buckets.Remove(bucket);
            await _context.SaveChangesAsync();
        }        
    }
}