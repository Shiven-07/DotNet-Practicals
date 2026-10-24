using Microsoft.EntityFrameworkCore;
using WebApplication5.Models;
namespace WebApplication5.Models.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

public DbSet<Product> Products { get; set; }
    }
}
