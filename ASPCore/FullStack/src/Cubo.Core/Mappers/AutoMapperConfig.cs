using AutoMapper;
using Cubo.Core.Domain;
using Cubo.Core.DTO;
using System.Linq;

namespace Cubo.Core.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper GetMapper()
        {
            var config = new MapperConfiguration(c => 
            {
                c.CreateMap<Bucket, BucketDTO>()
                    .ForMember(m => m.Items, 
                        m => m.MapFrom(p => p.Items
                            .Select(i => i.Key)
                            .OrderBy(i => i)));

                c.CreateMap<Item, ItemDTO>();
            });
            
            return config.CreateMapper();
        }
    }
}