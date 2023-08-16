using Microsoft.EntityFrameworkCore;
using WebApplication1.Features.Products.Models;

namespace WebApplication1.Data
{
    public class StoreDbContext: DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options): base(options) { }

        public DbSet<ProductEntity> Products { get; set; }
    }
}
