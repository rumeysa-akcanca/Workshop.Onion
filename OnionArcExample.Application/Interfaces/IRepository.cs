using OnionArcExample.Domain.Common;


namespace OnionArcExample.Application.Interfaces
{

    public interface IRepository<T> where T :BaseEntity , new() //buraki new ne ?
    {
        Task<List<T>> GetAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> AddAsync(T entity);
    }
   
}
