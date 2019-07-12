using Pandora.NetStandard.Core.Base;
using Pandora.NetStandard.Core.Interfaces;
using Pandora.NetStandard.Core.Mapper;
using Pandora.NetStandard.Core.Utils;
using Prog3.RestoDotNet.Business.Mappers;
using Prog3.RestoDotNet.Business.Services.Contracts;
using Prog3.RestoDotNet.Core.Utils;
using Prog3.RestoDotNet.Model.Dtos;
using Prog3.RestoDotNet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3.RestoDotNet.Business.Services
{
    public class TableSvc : BaseService<Table, TableDto>, ITableSvc
    {
        public TableSvc(IApplicationUow applicationUow)
            : base(applicationUow, new TableMapper())
        {
        }

        public async Task<BLResponse> CleanTableForInitialUsageAsync()
        {
            var response = new BLResponse();

            try
            {
                await _uow.EFRepository<Table>().ExecuteQueryAsync("TRUNCATE TABLE [Resto].[Tables]"); 
            }
            catch (Exception ex)
            {
                HandleSVCException(response, ex);
            }

            return response;
        }

        public Task<BLSingleResponse<TableDto>> CreateAsync(TableDto pDto)
        {
            throw new NotImplementedException();
        }

        public Task<BLSingleResponse<bool>> DeleteAsync(TableDto pDto)
        {
            throw new NotImplementedException();
        }

        public Task<BLListResponse<TableDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public BLListResponse<TableDto> GetAllByTrackId(Guid trackId)
        {
            var response = new BLListResponse<TableDto>();

            try
            {
                var entityResp = AsyncHelper.RunSync(() =>
                {
                    return _uow.EFRepository<Table>().AllAsync(t => t.BoundedMapId == trackId, null, null);
                });

                response.Data = _mapper.MapFromEntity(entityResp);
            }
            catch (Exception ex)
            {
                HandleSVCException(response, ex);
            }

            return response;
        }

        public Task<BLSingleResponse<TableDto>> GetByIdAsync(int pId)
        {
            //var a = await _uow.GetRepo<Table>().GetByIdAsync(pId);
            throw new NotImplementedException();
        }

        public async Task<BLSingleResponse<bool>> SetInitialTableArrangementAsync(IEnumerable<TableDto> tablesDtos)
        {
            var response = new BLSingleResponse<bool>();

            try
            {
                foreach (TableDto table in tablesDtos)
                {
                    var entityReult = _mapper.MapToEntity(table);
                    await _uow.EFRepository<Table>().InsertAsync(entityReult);
                }

                response.Data = await _uow.CommitAsync();
            }
            catch (Exception ex)
            {
                HandleSVCException(response, ex);
            }

            return response;
        }

        public async Task<BLSingleResponse<bool>> UpdateAsync(TableDto pDto)
        {
            var response = new BLSingleResponse<bool>();

            try
            {
                var entity = _mapper.MapToEntity(pDto);
                await _uow.EFRepository<Table>().UpdateAsync(entity);

                response.Data = await _uow.CommitAsync();
            }
            catch (Exception ex)
            {
                HandleSVCException(response, ex);
            }

            return response;
        }

    }
}
