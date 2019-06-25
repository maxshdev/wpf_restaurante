﻿using Pandora.NetStandard.Core.Utils;
using System.Threading.Tasks;

namespace Pandora.NetStandard.Core.Interfaces
{
    public interface IBasicCrudOperations<TDto>
    {
        Task<BLListResponse<TDto>> GetAllAsync();
        Task<BLSingleResponse<TDto>> GetByIdAsync(int pId);
        Task<BLSingleResponse<TDto>> CreateAsync(TDto pDto);
        Task<BLSingleResponse<bool>> UpdateAsync(TDto pDto);
        Task<BLSingleResponse<bool>> DeleteAsync(TDto pDto);
    }
}
