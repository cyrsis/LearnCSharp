using System;
using System.Linq;
using System.Threading.Tasks;
using Cubo.Core.Domain;
using Cubo.Core.Repositories;
using Cubo.Core.Services;

namespace Cubo.Core.Services
{
    public class DataInitializer : IDataInitializer
    {
        private readonly IBucketRepository _bucketRepository;

        public DataInitializer(IBucketRepository bucketRepository)
        {
            _bucketRepository = bucketRepository;
        }

        public async Task SeedAsync()
        {
            var names = await _bucketRepository.GetNamesAsync();
            if(names.Any())
            {
                return;
            }
            for(var i=0; i<3; i++)
            {
                await _bucketRepository.AddAsync(CreateBucket(i));
            }           
        }

        private static Bucket CreateBucket(int number)
        {
            var bucketId = Guid.NewGuid();
            var bucket = new Bucket(bucketId, $"bucket-{number}");
            for(var i=0; i<3; i++)
            {
                bucket.AddItem($"Item-{Guid.NewGuid()}", $"Value {Guid.NewGuid()}");
            }

            return bucket;
        }
    }
}