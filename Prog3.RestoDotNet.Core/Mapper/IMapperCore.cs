using AutoMapper;
using System.Collections.Generic;

namespace Pandora.NetStandard.Core.Mapper
{
    public interface IMapperCore<TInputEntity, TOutputDto>
    {
        void SetMapperConfiguration(IMapper pMapperConfig);
        TOutputDto MapFromEntity(TInputEntity pEntity);
        IEnumerable<TOutputDto> MapFromEntity(IEnumerable<TInputEntity> pEntities);
        TInputEntity MapToEntity(TOutputDto pEntity);
        IEnumerable<TInputEntity> MapToEntity(IEnumerable<TOutputDto> pEntities);
    }
    public interface IMapperCore
    {
        TOutputEntity MapEntity<TInputEntity, TOutputEntity>(TInputEntity pEntity, IMapper pMapperConfig = null);
        IEnumerable<TOutputEntity> MapEntity<TInputEntity, TOutputEntity>(IEnumerable<TInputEntity> pEntities, IMapper pMapperConfig = null);
        TBaseClass MapToBaseClass<TDerivedClass, TBaseClass>(TDerivedClass pEntity);
        IEnumerable<TBaseClass> MapToBaseClass<TDerivedClass, TBaseClass>(IEnumerable<TDerivedClass> pEntities);
    }
}
