using System.Threading.Tasks;
using System;

namespace Pandora.NetStandard.Core.Interfaces
{
    public interface IApplicationUow : IDisposable
    {
        IEfRepository<TEntity> EFRepository<TEntity>() where TEntity : class;
        bool Commit();
        Task<bool> CommitAsync();
    }
}
