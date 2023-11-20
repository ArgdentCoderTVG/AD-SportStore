using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using SportStore.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace SportStore.Data
{
    public class SportStoreDbContext : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SportStoreDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Randomly generated sport store articles
            modelBuilder.Entity<Category>().HasData(
                new Category() { CategoryId = 2, Name = "Running Shoes" },
                new Category() { CategoryId = 3, Name = "Fitness Gear" },
                new Category() { CategoryId = 4, Name = "Outdoor Sports" },
                new Category() { CategoryId = 5, Name = "Team Sports" },
                new Category() { CategoryId = 6, Name = "Swimming" },
                new Category() { CategoryId = 7, Name = "Cycling" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product() { ProductId = 2, Name = "Trailblazer Running Shoes", Description = "Durable all-terrain running shoes", Price = new decimal(120.0), ImageUrl = "/img/trailblazer-running-shoes.png" },
                new Product() { ProductId = 3, Name = "Gym Duffel Bag", Description = "Spacious and sturdy bag for all your fitness gear", Price = new decimal(35.5), ImageUrl = "/img/gym-duffel-bag.png" },
                new Product() { ProductId = 4, Name = "Hiking Backpack", Description = "Lightweight backpack for outdoor adventures", Price = new decimal(47.3), ImageUrl = "/img/hiking-backpack.png" },
                new Product() { ProductId = 5, Name = "Soccer Ball", Description = "Professional quality soccer ball", Price = new decimal(22.0), ImageUrl = "/img/soccer-ball.png" },
                new Product() { ProductId = 6, Name = "Swim Goggles", Description = "Anti-fog and UV-protected swim goggles", Price = new decimal(15.75), ImageUrl = "/img/swim-goggles.png" },
                new Product() { ProductId = 7, Name = "Road Bike", Description = "High-performance road bike for cycling enthusiasts", Price = new decimal(870.0), ImageUrl = "/img/road-bike.png" }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

}