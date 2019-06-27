using Pandora.NetStandard.Core.Base;
using Pandora.NetStandard.Core.Interfaces;
using Pandora.NetStandard.Core.Mapper;
using Pandora.NetStandard.Core.Utils;
using Prog3.RestoDotNet.Business.Mappers;
using Prog3.RestoDotNet.Business.Services.Contracts;
using Prog3.RestoDotNet.Business.States;
using Prog3.RestoDotNet.Model.Dtos;
using Prog3.RestoDotNet.Model.Entities;
using System;
using System.Threading.Tasks;

namespace Prog3.RestoDotNet.Business.Services
{
    public class OrderSvc : BaseService<Order, OrderDto>, IOrderSvc
    {
        public OrderSvc(IApplicationUow applicationUow)
            : base(applicationUow, new OrderMapper())
        {
        }

        public Task<BLSingleResponse<decimal>> CloseOrderAndGetTotalPriceAsync(OrderDto consumeDto)
        {
            throw new NotImplementedException();
        }

        public async Task<BLSingleResponse<int>> OpenAndGetOrderIdAsync(OrderDto consumeDto)
        {
            var response = new BLSingleResponse<int>();

            try
            {
                TableStateManager stateManager = await TableStateManager.GetTableStateManagerAsync(consumeDto);
                if (await stateManager.AssigningAsync(consumeDto))
                {
                    var resp = await _uow.GetEfRepository<Order>().InsertAsync(consumeDto.BaseEntity);
                    await _uow.CommitAsync();
                    response.Data = resp.Id;
                }
            }
            catch (Exception ex)
            {
                HandleSVCException(ex);
            }

            return response;
        }

        public Task<BLSingleResponse<int>> SetReservationAndGetOrderIdAsync(TableDto tableDto)
        {
            throw new NotImplementedException();
        }
    }
}
