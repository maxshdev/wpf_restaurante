using Pandora.NetStandard.Core.Interfaces;
using Pandora.NetStandard.Core.Utils;
using Prog3.RestoDotNet.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prog3.RestoDotNet.Business.Services.Contracts
{
    public interface ITableSvc : IBasicCrudOperations<TableDto>
    {
        Task<BLSingleResponse<bool>> SetInitialTableArrangementAsync(IEnumerable<TableDto> tablesDtos);
        Task<BLResponse> CleanTableForInitialUsageAsync();
        Task<BLListResponse<TableDto>> GetAllByTrackId(Guid trackId);
    }
}
