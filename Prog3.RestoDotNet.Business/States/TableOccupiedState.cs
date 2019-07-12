using Prog3.RestoDotNet.Model.Dtos;
using System;
using System.Threading.Tasks;

namespace Prog3.RestoDotNet.Business.States
{
    public class TableOccupiedState : TableStateManager
    {
        public override Task<bool> SaveAsync(OrderDto consumeDto)
        {
            //do nothing
            return Task.Run(() => { return true; });
        }

        public async override Task<bool> CloseAsync(OrderDto consumeDto)
        {
            consumeDto.Table.State = Model.Enums.TableStateEnum.DISPONIBLE;
            var resp = await _tableSvc.UpdateAsync(consumeDto.Table);
            return resp.Data;
        }
    }
}
