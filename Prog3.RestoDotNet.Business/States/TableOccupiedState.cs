using Prog3.RestoDotNet.Model.Dtos;
using System;
using System.Threading.Tasks;

namespace Prog3.RestoDotNet.Business.States
{
    public class TableOccupiedState : TableStateManager
    {
        public override Task<bool> SaveAsync(OrderDto consumeDto)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> CloseAsync(OrderDto consumeDto)
        {
            throw new NotImplementedException();
        }
    }
}
