using Pandora.NetStandard.Core.Interfaces;
using Pandora.NetStandard.Core.Mapper;
using Pandora.NetStandard.Core.Utils;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.NetStandard.Core.Base
{
    public abstract class BaseService
    {
        protected readonly IApplicationUow _uow;

        public BaseService(IApplicationUow applicationUow)
        {
            _uow = applicationUow;
        }

        protected void HandleSVCException(Exception pEx)
        {
            HandleSVCException(BLResponse.GetVoidResponse(HttpStatusCode.InternalServerError), pEx);
        }

        protected void HandleSVCException(BLResponse pResponse, Exception pEx)
        {
            List<string> errs = new List<string>();
            do
            {
                errs.Add(pEx.Message);
                pEx = pEx.InnerException;

            } while (pEx != null);

            HandleSVCException(pResponse, errs.ToArray());
        }
        //TODO: response generic error msg on prod mode
        protected void HandleSVCException(BLResponse pResponse, params string[] pErrors)
        {
            string defaultMsg = "Internal Error at Service Layer. ";
            pResponse.Errors.Add(defaultMsg);
            pResponse.Errors.AddRange(pErrors);
        }
    }

    public abstract class BaseService<TEntity, TDto> : BaseService
    {
        protected readonly IMapperCore<TEntity, TDto> _mapper;

        public BaseService(IApplicationUow applicationUow, IMapperCore<TEntity, TDto> mapperCore) : base(applicationUow)
        {
            _mapper = mapperCore;
        }
    }
}
