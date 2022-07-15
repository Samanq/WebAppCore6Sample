using WebAppCore6Sample.Api.Entities;

namespace WebAppCore6Sample.Api.Repositories.Interfaces;

public interface IUserRepository : IGenericRepository<User>
{
    public Task<User> GetByEmail(string email);
}
