using Prog3.RestoDotNet.Business.Services.Contracts;
using Pandora.NetStandard.Core.Utils;
using System.Threading.Tasks;
using Prog3.RestoDotNet.Model.Dtos;
using Prog3.RestoDotNet.Model.Enums;
using Prog3.RestoDotNet.Business.Services;

namespace Prog3.RestoDotNet.Business.States
{
    public abstract class TableStateManager 
    {
        protected static ITableSvc _tableSvc;

        public async static Task<TableStateManager> GetTableStateManagerAsync(ITableSvc tableSvc, OrderDto consumeDto)
        {
            _tableSvc = tableSvc;

            switch (consumeDto?.Table.State)
            {
                case TableStateEnum.DISPONIBLE:
                    return new TableAvailableState();
                case TableStateEnum.OCUPADO:
                    return new TableOccupiedState();
                case TableStateEnum.RESERVADO:
                    return new TableReservedState();
                default:
                    return new TableAvailableState();
            }
        }

        public abstract Task<bool> CloseAsync(OrderDto consumeDto);
        public abstract Task<bool> SaveAsync(OrderDto consumeDto);

        protected virtual bool StateManagerResponseHandler(BLResponse bLResponse)
        {
            if (bLResponse == null)
                throw new StateManagerException("Null Result Exception");
            else if (bLResponse.HasError)
                throw new StateManagerException(string.Concat(bLResponse.Errors.ToArray()));
            else
                return true;
        }
    }
}
