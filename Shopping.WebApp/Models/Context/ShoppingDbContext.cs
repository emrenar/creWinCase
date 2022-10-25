




using Microsoft.EntityFrameworkCore;

namespace Shopping.WebApp.Models.Context
{
    public class ShoppingDbContext:DbContext
    {
        public ShoppingDbContext(DbContextOptions options):base(options)
        {

        }
          
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
