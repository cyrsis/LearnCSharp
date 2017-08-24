using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Cubo.Core.DTO;
using Cubo.Core.Repositories;
using Newtonsoft.Json;

namespace Cubo.Core.Services
{
    public class ItemService : IItemService
    {
        private readonly IBucketRepository _bucketRepository;
        private readonly IMapper _mapper;
        
        public ItemService(IBucketRepository bucketRepository, IMapper mapper)
        {
            _bucketRepository = bucketRepository;
            _mapper = mapper;
        }
        
        public async Task AddAsync(string bucketName, string key, object value)
        {
            var bucket = await _bucketRepository.GetOrFailAsync(bucketName);
            bucket.AddItem(key, JsonConvert.SerializeObject(value));
            await _bucketRepository.UpdateAsync(bucket);
        }

        public async Task<ItemDTO> GetAsync(string bucketName, string key)
        {
            var bucket = await _bucketRepository.GetOrFailAsync(bucketName);
            var item = bucket.GetItemOrFail(key);

            return _mapper.Map<ItemDTO>(item);
        }

        public async Task<IEnumerable<string>> GetKeysAsync(string bucketName)
        {
            var bucket = await _bucketRepository.GetOrFailAsync(bucketName);

            return bucket.Items.Select(x => x.Key);
        }

        public async Task RemoveAsync(string bucketName, string key)
        {
            var bucket = await _bucketRepository.GetOrFailAsync(bucketName);
            bucket.RemoveItem(key);
            await _bucketRepository.UpdateAsync(bucket);
        }
    }
}