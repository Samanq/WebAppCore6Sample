using WebAppCore6Sample.Mvc.Models;
using WebAppCore6Sample.Mvc.Services.Interfaces;

namespace WebAppCore6Sample.Mvc.Services;

public class ProductHttpClientService : IProductHttpClientService
{
    public HttpClient Client { get; }

    public ProductHttpClientService(HttpClient client)
        => Client = client;

    public async Task<IEnumerable<Product>> GetAll()
    {
        return await Client.GetFromJsonAsync<IEnumerable<Product>>($"/api/Products");
    }

    public async Task<Product> GetById(long id)
    {
        return await Client.GetFromJsonAsync<Product>($"/api/Products/{id}");
    }

    public async Task Create(Product product)
    {
        // //client.PostAsync(uri, new StringContent(jsonInString, Encoding.UTF8, "application/json"));
        await Client.PostAsJsonAsync<Product>($"/api/Products/", product);
    }

    public async Task Edit(Product product)
    {
        await Client.PutAsJsonAsync<Product>($"/api/Products/{product.Id}", product);
    }

    public async Task Delete(long id)
    {
        await Client.DeleteAsync($"/api/Products/{id}");
    }
}