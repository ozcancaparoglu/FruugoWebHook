using Order.Domain.Common;

namespace Order.Application.Contracts.Persistence
{
    public interface IUnitOfWork
    {
        IAsyncRepository<T> Repository<T>() where T : EntityBase;
        Task<int> CommitAsync();
        void Rollback();
    }
}
