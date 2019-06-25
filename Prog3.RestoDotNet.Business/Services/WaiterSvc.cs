using Prog3.RestoDotNet.Business.Mappers;
using Prog3.RestoDotNet.Business.Services.Contracts;
using Pandora.NetStandard.Core.Interfaces;
using Pandora.NetStandard.Core.Base;
using Pandora.NetStandard.Core.Utils;
using Prog3.RestoDotNet.Model.Dtos;
using Prog3.RestoDotNet.Model.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Prog3.RestoDotNet.Business.Services
{
    public class WaiterSvc : BaseService<Waiter, WaiterDto>, IWaiterSvc
    {
        public WaiterSvc(IApplicationUow applicationUow)
            : base(applicationUow, new WaiterToDtoMapper())
        {

        }

        public async Task<BLSingleResponse<WaiterDto>> CreateAsync(WaiterDto pDto)
        {
            var response = new BLSingleResponse<WaiterDto>();

            try
            {
                var entityResult = await _uow.GetRepo<Waiter>().InsertAsync(pDto.BaseEntity);
                if (await _uow.CommitAsync())
                {
                    response.Data = _mapper.MapEntity(entityResult);
                }
                else
                {
                    HandleSVCException(response, "This action couldn't be performed.");
                }
            }
            catch (Exception ex)
            {
                HandleSVCException(response, ex);
            }

            return response;
        }

        public Task<BLSingleResponse<bool>> DeleteAsync(WaiterDto pDto)
        {
            throw new NotImplementedException();
        }

        public Task<BLListResponse<WaiterDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<BLListResponse<WaiterDto>> GetWaitersAttendsBySubjectId(int pSubjectId)
        {
            var response = new BLListResponse<WaiterDto>();

            try
            {
                
            }
            catch (Exception ex)
            {
                HandleSVCException(response, ex);
            }

            return response;
        }

        public async Task<BLSingleResponse<bool>> SaveWaiterExams(WaiterDto pWaiter)
        {
            var response = new BLSingleResponse<bool>();

            try
            {
                await _uow.GetRepo<Waiter>().UpdateAsync(pWaiter.BaseEntity);
                if (await _uow.CommitAsync())
                {
                    response.Data = true;
                }
                else
                {
                    HandleSVCException(response, "This action couldn't be performed.");
                }
            }
            catch (Exception ex)
            {
                HandleSVCException(response, ex);
            }

            return response;
        }

        public async Task<BLSingleResponse<WaiterDto>> GetByIdAsync(int pId)
        {
            var response = new BLSingleResponse<WaiterDto>();

            try
            {
                var entityResult = await _uow.GetRepo<Waiter>().GetByIdAsync(pId);
                response.Data = _mapper.MapEntity(entityResult);
            }
            catch (Exception ex)
            {
                HandleSVCException(response, ex);
            }

            return response;
        }

        public Task<BLSingleResponse<bool>> UpdateAsync(WaiterDto pDto)
        {
            throw new NotImplementedException();
        }

        public async Task<BLListResponse<WaiterDto>> GetWaitersExamsBySubjectId(int pSubjectId)
        {
            var response = new BLListResponse<WaiterDto>();

            try
            {
                
            }
            catch (Exception ex)
            {
                HandleSVCException(response, ex);
            }

            return response;
        }
    }
}
