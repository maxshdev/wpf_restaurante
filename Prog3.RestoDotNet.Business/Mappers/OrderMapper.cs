using AutoMapper;
using Pandora.NetStandard.Core.Mapper;
using Prog3.RestoDotNet.Model.Dtos;
using Prog3.RestoDotNet.Model.Entities;
using System.Collections.Generic;

namespace Prog3.RestoDotNet.Business.Mappers
{
    public class OrderMapper : GenericMapperCore<Order, OrderDto>
    {
        protected override IMapper CreateMapConfiguration()
        {
            return new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderDto>();
                c.CreateMap<Waiter, WaiterDto>();
                c.CreateMap<Meal, MealDto>();
                c.CreateMap<Table, TableDto>();

            }).CreateMapper();
        }

        protected override IMapper CreateReverseMapConfiguration()
        {
            return new MapperConfiguration(c =>
            {
                c.CreateMap<OrderDto, Order>();

                c.CreateMap<WaiterDto, Waiter>();
                c.CreateMap<MealDto, Meal>();
                c.CreateMap<TableDto, Table>();

            }).CreateMapper();
        }
    }
}
