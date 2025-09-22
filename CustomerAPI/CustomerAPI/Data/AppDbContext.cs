using CustomerAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CustomerAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
