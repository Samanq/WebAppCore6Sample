using Microsoft.EntityFrameworkCore;
using WebAppCore6Sample.Api.DataContexts;
using WebAppCore6Sample.Api.Entities;
using WebAppCore6Sample.Api.Repositories.Interfaces;

namespace WebAppCore6Sample.Api.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    private readonly DataContext _dataContext;

    public UserRepository(DataContext dataContext) 
        : base(dataContext)
    {
        _dataContext = dataContext;
    }
    public async Task<User> GetByEmail(string email)
    {
        return await _dataContext.Users.SingleOrDefaultAsync(
                                            u => u.Email.ToLower() == email.ToLower());
    }
}
