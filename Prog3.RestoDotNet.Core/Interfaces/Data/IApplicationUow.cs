using System.Threading.Tasks;
using System;

namespace Pandora.NetStandard.Core.Interfaces
{
    public interface IApplicationUow : IDisposable
    {
        IRepository<TEntity> GetRepo<TEntity>() where TEntity : class;
        bool Commit();
        Task<bool> CommitAsync();
    }
}
