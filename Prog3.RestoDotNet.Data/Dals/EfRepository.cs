﻿using Pandora.NetStandard.Core.Base;
using Pandora.NetStandard.Core.Interfaces;
using Pandora.NetStandard.Core.Utils;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Prog3.RestoDotNet.Data.Dals
{
    public class EfRepository<TEntity> : IEfRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;

        public EfRepository(DbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public async Task<IQueryable<TEntity>> AllAsync(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>,
            IOrderedQueryable<TEntity>> orderBy, params Expression<Func<TEntity, object>>[] includes)
        {
            return await Task.Run(() =>
            {
                IQueryable<TEntity> entities = _dbSet.IncludeMultiple(includes);

                if (predicate != null)
                {
                    entities = entities.Where(predicate);
                }

                return orderBy != null ? orderBy(entities) : entities;
            });
        }

        public async Task<BLPagedResponse<TEntity>> AllPagedAsync(int skip, int take, int pageSize, int currentPage,
            Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy,
            params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> entities = _dbSet.IncludeMultiple(includes);

            if (predicate != null)
            {
                entities = entities.Where(predicate);
            }

            var totalCount = entities.Count();
            var totalPages = Math.Ceiling((double)totalCount / pageSize);

            return await Task.Run(() =>
            {
                return new BLPagedResponse<TEntity>
                {
                    Data = orderBy != null
                        ? orderBy(entities).Skip(skip).Take(take)
                        : entities.Skip(skip).Take(take),
                    CollectionLength = totalCount,
                    CurrentPage = currentPage,
                    RowsPerPage = pageSize,
                    TotalPages = totalPages
                };
            });
        }

        public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] includes)
        {
            return await _dbSet.IncludeMultiple(includes).FirstOrDefaultAsync(predicate);
        }

        public async Task<TEntity> GetByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<TEntity> GetByExpressionAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet
                .AsNoTracking()
                .FirstOrDefaultAsync(predicate);
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            var result = await Task.Run(() =>
            {
                return _dbSet.Add(entity);
            });
            return result;
        }


        public async Task DeleteAsync(object id)
        {
            await DeleteAsync(_dbSet.Find(id));
        }

        public async Task DeleteAsync(TEntity entityToDelete)
        {
            await Task.Run(() =>
            {
                _dbSet.Attach(entityToDelete);
                _dbSet.Remove(entityToDelete);
            });
        }

        public async Task UpdateAsync(TEntity entityToUpdate)
        {
            await Task.Run(() =>
            {
                _dbContext.Entry<TEntity>(entityToUpdate).State = EntityState.Modified;
            });
        }

        public async Task<int> GetCountAsync()
        {
            return await Task.Run(() =>
            {
                return _dbSet.Count();
            });
        }

        public async Task<int> GetCountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Task.Run(() =>
            {
                return _dbSet.Count(predicate);
            });
        }

        public async Task<int> ExecuteQueryAsync(string query, params object[] paramaters)
        {
            return await Task.Run(() =>
            {
                return 1;
            });
        }

        public async Task<bool> ExistAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.AnyAsync(predicate);
        }
    }
}
