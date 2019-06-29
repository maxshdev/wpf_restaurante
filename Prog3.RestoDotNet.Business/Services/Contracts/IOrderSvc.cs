using Pandora.NetStandard.Core.Utils;
using Prog3.RestoDotNet.Model.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prog3.RestoDotNet.Business.Services.Contracts
{
    public interface IOrderSvc
    {
        Task<BLSingleResponse<bool>> SaveOrderAsync(OrderDto consumeDto);
        Task<BLSingleResponse<int>> OpenAndGetOrderIdAsync(OrderDto consumeDto);
        Task<BLSingleResponse<decimal>> CloseOrderAndGetTotalPriceAsync(OrderDto consumeDto);
        Task<BLSingleResponse<int>> SetReservationAndGetOrderIdAsync(TableDto tableDto);
    }
}
