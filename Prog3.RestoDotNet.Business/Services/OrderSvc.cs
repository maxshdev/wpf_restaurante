using Pandora.NetStandard.Core.Utils;
using Prog3.RestoDotNet.Business.Services.Contracts;
using Prog3.RestoDotNet.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3.RestoDotNet.Business.Services
{
    public class OrderSvc : IOrderSvc
    {
        public Task<BLSingleResponse<decimal>> CloseOrderAndGetTotalPriceAsync(OrderDto consumeDto)
        {
            throw new NotImplementedException();
        }

        public Task<BLSingleResponse<int>> OpenAndGetOrderIdAsync(OrderDto consumeDto)
        {
            throw new NotImplementedException();
        }

        public Task<BLSingleResponse<int>> SetReservationAndGetOrderIdAsync(TableDto tableDto)
        {
            throw new NotImplementedException();
        }
    }
}
