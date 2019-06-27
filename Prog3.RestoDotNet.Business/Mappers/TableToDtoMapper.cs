using AutoMapper;
using Pandora.NetStandard.Core.Mapper;
using Prog3.RestoDotNet.Model.Dtos;
using Prog3.RestoDotNet.Model.Entities;

namespace Prog3.RestoDotNet.Business.Mappers
{
    public class TableToDtoMapper : GenericMapperCore<Table, TableDto>
    {
        protected override IMapper CreateMapConfiguration()
        {
            return new MapperConfiguration(c =>
            {
                c.CreateMap<Table, TableDto>();
            }).CreateMapper();
        }

        protected override IMapper CreateReverseMapConfiguration()
        {
            return new MapperConfiguration(c =>
            {
                c.CreateMap<TableDto, Table>();
            }).CreateMapper();
        }
    }
}
