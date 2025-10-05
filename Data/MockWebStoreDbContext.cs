using Microsoft.EntityFrameworkCore;
using MockWebStoreAPI.DataModels;

namespace MockWebStoreAPI.Data
{
    public class MockWebStoreDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MockWebStore.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasDiscriminator<string>("ProductType")
                                          .HasValue<WeaponProduct>("Weapon")
                                          .HasValue<ArmourProduct>("Armour");
        }
    }
}
