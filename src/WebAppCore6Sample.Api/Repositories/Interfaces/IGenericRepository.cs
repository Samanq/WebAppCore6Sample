using Microsoft.EntityFrameworkCore;
using WebAppCore6Sample.Api.DataContexts;

namespace WebAppCore6Sample.Api.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        DataContext DataContext { get; }
        DbSet<T> Table { get; }

        Task Add(T t);
        Task Delete(long id);
        Task Edit(T t);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(long id);
    }
}