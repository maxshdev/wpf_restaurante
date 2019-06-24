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
            return DefaultMapConfiguration();
        }
    }
}
