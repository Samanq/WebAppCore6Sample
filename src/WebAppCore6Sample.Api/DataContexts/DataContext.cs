using Microsoft.EntityFrameworkCore;
using WebAppCore6Sample.Api.Entities;

namespace WebAppCore6Sample.Api.DataContexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {

    }

    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
}
