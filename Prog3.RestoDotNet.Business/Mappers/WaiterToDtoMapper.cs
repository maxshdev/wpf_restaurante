using AutoMapper;
using Pandora.NetStandard.Core.Mapper;
using Prog3.RestoDotNet.Model.Dtos;
using Prog3.RestoDotNet.Model.Entities;

namespace Prog3.RestoDotNet.Business.Mappers
{
    public class WaiterToDtoMapper : GenericMapperCore<Waiter, WaiterDto>
    {
        protected override IMapper CreateMapConfiguration()
        {
            return new MapperConfiguration(c =>
            {
                c.CreateMap<Waiter, WaiterDto>()
                .ForMember(m => m.BaseEntity, o => o.MapFrom(s => s))
                .ReverseMap();

            }).CreateMapper();
        }
    }
}
