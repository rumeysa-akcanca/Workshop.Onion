using Microsoft.EntityFrameworkCore;
using OnionArcExample.Application.Interfaces.Context;
using OnionArcExample.Domain.Entities;

namespace OnionArcExample.Persistence.Context
{
    public class ApplicationDbContext : DbContext, IApplicationContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
        
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = Guid.NewGuid(), Description = "Pamuklu ", Name = "Gömlek", Price = 12, Stock = 12 ,CreateTime = DateTime.Now},
                new Product { Id = Guid.NewGuid(), Description = "Kadife ", Name = "Pantolan", Price = 12, Stock = 22 , CreateTime = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Description = "Yün ", Name = "Hırka", Price = 12, Stock = 32, CreateTime = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Description = "Polyester ", Name = "Kazak", Price = 12, Stock = 42, CreateTime = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Description = "Keten ", Name = "Etek", Price = 12, Stock = 52, CreateTime = DateTime.Now }
                );

        }

    }
}
