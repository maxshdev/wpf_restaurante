using AutoMapper;
using Pandora.NetStandard.Core.Mapper;
using Prog3.RestoDotNet.Model.Dtos;
using Prog3.RestoDotNet.Model.Entities;

namespace Prog3.RestoDotNet.Business.Mappers
{
    public class OrderToDtoMapper : GenericMapperCore<Order, OrderDto>
    {
        protected override IMapper CreateMapConfiguration()
        {
            return new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderDto>()
                .ForMember(m => m.BaseEntity, o => o.MapFrom(s => s));

            }).CreateMapper();
        }
    }
}
