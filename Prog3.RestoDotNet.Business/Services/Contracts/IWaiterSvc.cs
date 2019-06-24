using Pandora.NetStandard.Core.Interfaces;
using Pandora.NetStandard.Core.Utils;
using Prog3.RestoDotNet.Model.Dtos;
using System.Threading.Tasks;

namespace Prog3.RestoDotNet.Business.Services.Contracts
{
    public interface IWaiterSvc : IBasicCrudOperations<WaiterDto>
    {
        Task<BLListResponse<WaiterDto>> GetWaitersAttendsBySubjectId(int pSubjectId);
        Task<BLSingleResponse<bool>> SaveWaiterExams(WaiterDto pWaiter);
        Task<BLListResponse<WaiterDto>> GetWaitersExamsBySubjectId(int pSubjectId);
    }
}
