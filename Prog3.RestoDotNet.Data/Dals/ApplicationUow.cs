using Pandora.NetStandard.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prog3.RestoDotNet.Data.Dals
{
    public class ApplicationUow : IApplicationUow, IDisposable
    {
        private readonly RestoDbContext _dbContext;

        public ApplicationUow(RestoDbContext dbContext)
        {
            _dbContext = dbContext;
            RepositoriesCache = new Dictionary<Type, object>();
        }


        /// <summary>
        /// Save pending changes to the database and return true if there was at least 1 row affected
        /// </summary>
        public bool Commit()
        {
            //System.Diagnostics.Debug.WriteLine("Committed");
            return _dbContext.SaveChanges() > 0;
        }

        /// <summary>
        /// Save pending changes to the database asyncly and return the amount of affected rows
        /// </summary>
        public async Task<bool> CommitAsync()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }


        public IEfRepository<T> GetEfRepository<T>() where T : class
        {
            return GetRepository<IEfRepository<T>>(ctx =>
            {
                return new EfRepository<T>(ctx);
            });
        }

        protected Dictionary<Type, object> RepositoriesCache { get; private set; }

        protected virtual T GetRepository<T>(Func<RestoDbContext, object> factory = null) where T : class
        {
            // Look for T dictionary cache under typeof(T).
            RepositoriesCache.TryGetValue(typeof(T), out object repoObj);
            if (repoObj != null)
            {
                return (T)repoObj;
            }

            // Not found or null; make one, add to dictionary cache, and return it.
            return MakeRepository<T>(factory, _dbContext);
        }

        protected virtual T MakeRepository<T>(Func<RestoDbContext, object> factory, RestoDbContext dbContext)
        {
            //var f = factory ?? _repositoryFactories.GetRepositoryFactory<T>();
            if (factory == null)
            {
                throw new ArgumentNullException("No factory for repository type: " + typeof(T).FullName);
            }
            var repo = (T)factory(dbContext);
            RepositoriesCache[typeof(T)] = repo;
            return repo;
        }

        #region IDisposable
        //TODO: see Dispose pattern
        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext?.Dispose();
            }
            disposed = true;
        }

        #endregion
    }
}
