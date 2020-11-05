using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Infrastructure.Data 
{
    public class StoreContext : DbContext {
        public StoreContext() { }
        public StoreContext(DbContextOptions<StoreContext> options) : base (options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=skinet.db");
        }

        public DbSet<Product> Products { get; set; }
    }
}