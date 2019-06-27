using AutoMapper;
using Pandora.NetStandard.Core.Interfaces;
using System.Collections.Generic;

namespace Pandora.NetStandard.Core.Mapper
{
    public abstract class GenericMapperCore<TInputEntity, TOutputDto>
        : IMapperCore<TInputEntity, TOutputDto>
        where TInputEntity : IEntity
    {
        protected IMapper MappingConfiguration { get; set; }

        public GenericMapperCore()
        {
            MappingConfiguration = CreateMapConfiguration();
        }

        protected IMapper DefaultMapConfiguration()
        {
            return new MapperConfiguration(c =>
            {
                //c.ForAllMaps((typeMap, mappingExpression) => mappingExpression.MaxDepth(2));
                c.CreateMap<TInputEntity, TOutputDto>().MaxDepth(2);
            }).CreateMapper();
        }

        protected abstract IMapper CreateMapConfiguration();

        protected virtual IMapper CreateReverseMapConfiguration()
        {
            return new MapperConfiguration(c =>
            {
                c.CreateMap<TOutputDto, TInputEntity>();
            }).CreateMapper();
        }

        public virtual void SetMapperConfiguration(IMapperConfigurationExpression configurationExpression)
        {
            //TODO: add expression param functionaity
            var expression = configurationExpression;
        }

        public virtual void SetMapperConfiguration(IMapper pMapperConfig)
        {
            MappingConfiguration = pMapperConfig;
        }

        public virtual TOutputDto MapFromEntity(TInputEntity entity)
        {
            if (entity == null) return default;
            return MappingConfiguration.Map<TOutputDto>(entity);
        }

        public virtual IEnumerable<TOutputDto> MapFromEntity(IEnumerable<TInputEntity> entity)
        {
            if (entity == null) return null;
            return MappingConfiguration.Map<IEnumerable<TOutputDto>>(entity);
        }

        public virtual TInputEntity MapToEntity(TOutputDto entity)
        {
            if (entity == null) return default;
            return CreateReverseMapConfiguration().Map<TInputEntity>(entity);
        }

        public virtual IEnumerable<TInputEntity> MapToEntity(IEnumerable<TOutputDto> entity)
        {
            if (entity == null) return null;
            return CreateReverseMapConfiguration().Map<IEnumerable<TInputEntity>>(entity);
        }
    }

    public class GenericMapperCore : IMapperCore
    {
        protected virtual IMapper CreateCustomMap<TInputEntity, TOutputEntity>()
        {
            return new MapperConfiguration(c =>
            {
                c.ForAllMaps((typeMap, mappingExpression) => mappingExpression.MaxDepth(1));
                c.CreateMap<TInputEntity, TOutputEntity>();
            }).CreateMapper();
        }

        public virtual TOutputEntity MapEntity<TInputEntity, TOutputEntity>(TInputEntity pEntity, IMapper pMapperConfig = null)
        {
            if (pEntity == null) return default;
            var mapper = pMapperConfig ?? CreateCustomMap<TInputEntity, TOutputEntity>();
            return mapper.Map<TOutputEntity>(pEntity);
        }

        public virtual IEnumerable<TOutputEntity> MapEntity<TInputEntity, TOutputEntity>(IEnumerable<TInputEntity> pEntities, IMapper pMapperConfig = null)
        {
            if (pEntities == null) return null;
            var mapper = pMapperConfig ?? CreateCustomMap<TInputEntity, TOutputEntity>();
            return mapper.Map<IEnumerable<TOutputEntity>>(pEntities);
        }

        public virtual TBaseClass MapToBaseClass<TDerivedClass, TBaseClass>(TDerivedClass pEntity)
        {
            if (pEntity == null) return default;
            return new MapperConfiguration(c =>
            {
                c.CreateMap<TDerivedClass, TBaseClass>();
            })
            .CreateMapper()
            .Map<TBaseClass>(pEntity);
        }

        public virtual IEnumerable<TBaseClass> MapToBaseClass<TDerivedClass, TBaseClass>(IEnumerable<TDerivedClass> pEntities)
        {
            if (pEntities == null) return null;
            return new MapperConfiguration(c =>
            {
                c.CreateMap<TDerivedClass, TBaseClass>();
            })
            .CreateMapper()
            .Map<IEnumerable<TBaseClass>>(pEntities);
        }
    }
}
