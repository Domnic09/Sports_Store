using Microsoft.EntityFrameworkCore;


namespace Taboada_SportsStore.Models
{
    public class StoreDBContext: DbContext
    {
        public StoreDBContext(DbContextOptions<StoreDBContext> options): base(options){ }
    public DbSet<Product> Products => Set<Product>();
                 
    }
}
