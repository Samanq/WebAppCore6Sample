using WebAppCore6Sample.Mvc.Models;

namespace WebAppCore6Sample.Mvc.Services.Interfaces
{
    public interface IProductHttpClientService
    {
        HttpClient Client { get; }

        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(long id);
        Task Create(Product product);
        Task Edit(Product product);
        Task Delete(long id);
    }
}