using Pandora.NetStandard.Core.Utils;
using Prog3.RestoDotNet.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prog3.RestoDotNet.Business.Services.Contracts
{
    public interface IOrderSvc
    {
        Task<BLSingleResponse<int>> OpenAndGetOrderIdAsync(OrderDto consumeDto);
        Task<BLSingleResponse<decimal>> CloseOrderAndGetTotalPriceAsync(OrderDto consumeDto);
        Task<BLSingleResponse<int>> SetReservationAndGetOrderIdAsync(TableDto tableDto);
    }
}
