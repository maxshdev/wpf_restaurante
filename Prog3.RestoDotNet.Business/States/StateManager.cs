using Prog3.RestoDotNet.Business.Services.Contracts;
using Pandora.NetStandard.Core.Utils;

namespace Prog3.RestoDotNet.Business.States
{
    public abstract class StateManager
    {
        //protected static IWaiterStateSvc _WaiterStateSvc;

        //public StateManager(IWaiterStateSvc WaiterStateSvc)
        //{
        //    _WaiterStateSvc = WaiterStateSvc;
        //}

        //public async static Task<StateManager> GetStateManagerAsync(IWaiterStateSvc WaiterStateSvc, int WaiterId, int subjectId)
        //{
        //    var validState = (await WaiterStateSvc.GetLastValidStateAsync(WaiterId, subjectId)).Data;

        //    switch (validState?.AcademicState)
        //    {
        //        case WaiterStateEnum.ENROLLED:
        //            return new WaiterEnrolledState(WaiterStateSvc);
        //        case WaiterStateEnum.ACTIVE:
        //            return null;
        //        case WaiterStateEnum.INACTIVE:
        //            return null;
        //        case WaiterStateEnum.ACHIEVED:
        //            return null;
        //        default:
        //            return new WaiterInitialState(WaiterStateSvc);
        //    }
        //}

        //public abstract Task<bool> EnrollWaiterAsync(WaiterDto WaiterDto, SubjectDto subjectDto);
        //public abstract Task<bool> SaveExamsResultAsync(IList<ExamDto> examDtos);
        //public abstract Task<bool> StoreAttendenceAsync(WaiterDto WaiterDto, SubjectDto subjectDto);

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
