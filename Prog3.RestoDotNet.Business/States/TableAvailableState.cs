using Prog3.RestoDotNet.Model.Dtos;
using System;
using System.Threading.Tasks;

namespace Prog3.RestoDotNet.Business.States
{
    public class TableAvailableState : TableStateManager
    {
        public override Task<bool> AssigningAsync(OrderDto consumeDto)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> ReleasingAsync(OrderDto consumeDto)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> ReservingAsync(OrderDto consumeDto)
        {
            throw new NotImplementedException();
        }
    }
}
