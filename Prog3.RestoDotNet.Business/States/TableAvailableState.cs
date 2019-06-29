using Prog3.RestoDotNet.Model.Dtos;
using System;
using System.Threading.Tasks;

namespace Prog3.RestoDotNet.Business.States
{
    public class TableAvailableState : TableStateManager
    {
        public async override Task<bool> SaveAsync(OrderDto consumeDto)
        {
            consumeDto.Table.State = Model.Enums.TableStateEnum.OCUPADO;
            var resp = await _tableSvc.UpdateAsync(consumeDto.Table);
            return resp.Data;
        }

        public override Task<bool> CloseAsync(OrderDto consumeDto)
        {
            throw new StateManagerException("No se puede guardar una mesa ocupada.");
        }
    }
}
