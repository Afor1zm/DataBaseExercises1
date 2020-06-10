using Microsoft.EntityFrameworkCore;
using System;

namespace DataBaseTutorial
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MyDatabase.sqlite");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 1, ProductAddled = true, ProductName = "Onion", ProductWeight = 0.5, ProductBuyedDate = DateTime.Parse("12/02/2020")});
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 2, ProductAddled = true, ProductName = "Salat", ProductWeight = 1, ProductBuyedDate = DateTime.Parse("12/02/2020") });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 3, ProductAddled = true, ProductName = "Pickle", ProductWeight = 2.5, ProductBuyedDate = DateTime.Parse("12/02/2020") });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 4, ProductAddled = true, ProductName = "Potato", ProductWeight = 8.56, ProductBuyedDate = DateTime.Parse("12/02/2020") });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 5, ProductAddled = false, ProductName = "Tomato", ProductWeight = 0.05, ProductBuyedDate = DateTime.Parse("12/02/2020") });

        }
    }    
}
