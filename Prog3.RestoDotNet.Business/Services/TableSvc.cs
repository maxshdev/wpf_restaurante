using Pandora.NetStandard.Core.Base;
using Pandora.NetStandard.Core.Interfaces;
using Pandora.NetStandard.Core.Mapper;
using Pandora.NetStandard.Core.Utils;
using Prog3.RestoDotNet.Business.Mappers;
using Prog3.RestoDotNet.Business.Services.Contracts;
using Prog3.RestoDotNet.Model.Dtos;
using Prog3.RestoDotNet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prog3.RestoDotNet.Business.Services
{
    public class TableSvc : BaseService<Table, TableDto>, ITableSvc
    {
        public TableSvc(IApplicationUow applicationUow)
            : base(applicationUow, new TableToDtoMapper())
        {
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

        public async Task<BLSingleResponse<TableDto>> GetByIdAsync(int pId)
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
                    
                    await _uow.GetRepo<Table>().InsertAsync(table.BaseEntity);
                }

                response.Data = await _uow.CommitAsync();
            }
            catch (Exception ex)
            {
                HandleSVCException(ex);
            }

            return response;
        }

        public Task<BLSingleResponse<bool>> UpdateAsync(TableDto pDto)
        {
            throw new NotImplementedException();
        }
    }
}
