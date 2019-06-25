using Prog3.RestoDotNet.Business.Services.Contracts;
using Pandora.NetStandard.Core.Utils;
using System.Threading.Tasks;
using Prog3.RestoDotNet.Model.Dtos;
using Prog3.RestoDotNet.Model.Enums;

namespace Prog3.RestoDotNet.Business.States
{
    public abstract class TableStateManager 
    {
        protected static ITableSvc _tableSvc;

        public async static Task<TableStateManager> GetTableStateManagerAsync(OrderDto consumeDto)
        {
            //var validState = (await WaiterStateSvc.GetLastValidStateAsync(WaiterId, subjectId)).Data;

            switch (consumeDto?.BaseEntity.Table.State)
            {
                case TableStateEnum.AVAILABLE:
                    return new TableAvailableState();
                case TableStateEnum.OCCUPIED:
                    return null;
                case TableStateEnum.RESERVED:
                    return null;
                default:
                    return new TableAvailableState();
            }
        }

        public abstract Task<bool> ReservingAsync(OrderDto consumeDto);
        public abstract Task<bool> AssigningAsync(OrderDto consumeDto);
        public abstract Task<bool> ReleasingAsync(OrderDto consumeDto);

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
