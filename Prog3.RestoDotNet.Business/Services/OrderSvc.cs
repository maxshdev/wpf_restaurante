using Pandora.NetStandard.Core.Base;
using Pandora.NetStandard.Core.Interfaces;
using Pandora.NetStandard.Core.Utils;
using Prog3.RestoDotNet.Business.Mappers;
using Prog3.RestoDotNet.Business.Services.Contracts;
using Prog3.RestoDotNet.Business.States;
using Prog3.RestoDotNet.Model.Dtos;
using Prog3.RestoDotNet.Model.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Prog3.RestoDotNet.Business.Services
{
    public class OrderSvc : BaseService<Order, OrderDto>, IOrderSvc
    {
        private readonly ITableSvc tableSvc;

        public OrderSvc(IApplicationUow applicationUow, ITableSvc tableSvc)
            : base(applicationUow, new OrderMapper())
        {
            this.tableSvc = tableSvc;
        }

        public async Task<BLSingleResponse<decimal>> CloseOrderAndGetTotalPriceAsync(OrderDto consumeDto)
        {
            var response = new BLSingleResponse<decimal>();

            try
            {
                var entity = await _uow.EFRepository<Order>().GetByIdAsync(consumeDto.Id);
                entity.DateTo = DateTime.Now;
                await _uow.EFRepository<Order>().UpdateAsync(entity);

                if (await _uow.CommitAsync())
                {
                    TableStateManager stateManager = TableStateManager.GetTableStateManager(tableSvc, consumeDto);
                    await stateManager.CloseAsync(consumeDto);
                    response.Data = entity.TotalPrice;
                }
            }
            catch (Exception ex)
            {
                HandleSVCException(response, ex);
            }

            return response;
        }

        public async Task<BLSingleResponse<int>> OpenAndGetOrderIdAsync(OrderDto consumeDto)
        {
            var response = new BLSingleResponse<int>();

            try
            {
                TableStateManager stateManager = TableStateManager.GetTableStateManager(tableSvc, consumeDto);
                if (await stateManager.SaveAsync(consumeDto))
                {
                    var resp = await _uow.EFRepository<Order>().InsertAsync(consumeDto.BaseEntity);
                    await _uow.CommitAsync();
                    response.Data = resp.Id;
                }
            }
            catch (Exception ex)
            {
                HandleSVCException(response, ex);
            }

            return response;
        }

        public async Task<BLSingleResponse<OrderDto>> RetrieveCurrentOpenOrderAsync(TableDto tableDto)
        {
            var response = new BLSingleResponse<OrderDto>();

            try
            {
                var entity = await _uow.EFRepository<Order>().FindAsync(o => o.Table.Id == tableDto.Id && !o.DateTo.HasValue, x => x.Table); //TODO: fix include issue
                entity.Meals = await _uow.EFRepository<Meal>().AllAsync(m => m.OrderId == entity.Id, null, null);
                response.Data = _mapper.MapFromEntity(entity);
            }
            catch (Exception ex)
            {
                HandleSVCException(response, ex);
            }

            return response;
        }

        public async Task<BLSingleResponse<bool>> SaveOrderAsync(OrderDto consumeDto)
        {
            var response = new BLSingleResponse<bool>();

            try
            {
                var entity = _mapper.MapToEntity(consumeDto);
                if (consumeDto.Table.State == Model.Enums.TableStateEnum.DISPONIBLE)
                {
                    entity.Table = null;
                    entity.Waiter = null;
                    var resp = await _uow.EFRepository<Order>().InsertAsync(entity);
                }

                foreach (Meal meal in entity.Meals.Where(m => m.Id < 0))//por cada comida nueva agregada
                {
                    meal.Id = default;
                    meal.OrderId = entity.Id > 0 ? entity.Id : 0;
                    var svcMeal = await _uow.EFRepository<Meal>().InsertAsync(meal);
                }

                if (await _uow.CommitAsync())
                {
                    TableStateManager stateManager = TableStateManager.GetTableStateManager(tableSvc, consumeDto);
                    response.Data = await stateManager.SaveAsync(consumeDto);
                }
            }
            catch (Exception ex)
            {
                HandleSVCException(response, ex);
            }

            return response;
        }

        public async Task<BLSingleResponse<int>> SetReservationAndGetOrderIdAsync(TableDto tableDto)
        {
            var response = new BLSingleResponse<int>();

            try
            {
                var entity = await _uow.EFRepository<Table>().GetByIdAsync(tableDto.Id);
                entity.State = Model.Enums.TableStateEnum.RESERVADO;
                await _uow.EFRepository<Table>().UpdateAsync(entity);

                await _uow.CommitAsync();
            }
            catch (Exception ex)
            {
                HandleSVCException(response, ex);
            }

            return response;
        }
    }
}
