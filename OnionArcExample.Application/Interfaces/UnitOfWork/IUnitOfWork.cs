using Microsoft.EntityFrameworkCore.Storage;
using OnionArcExample.Application.Interfaces.Repositories;


namespace OnionArcExample.Application.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        Task<IDbContextTransaction> BeginTransactionAsync();
        public IProductRepository ProductRepository { get; }
    }
}
