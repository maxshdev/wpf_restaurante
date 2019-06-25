using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Pandora.NetStandard.Core.Utils
{
    public static class EntityExtension
    {
        public static IQueryable<TEntity> IncludeMultiple<TEntity>(this IQueryable<TEntity> query,
            params Expression<Func<TEntity, object>>[] includes) where TEntity : class
        {
            if (includes != null)
            {
                query = includes.Aggregate(query, (current, include) => current.Include(include));
            }

            return query;
        }
    }
}
