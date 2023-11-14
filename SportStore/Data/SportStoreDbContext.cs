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
            modelBuilder.Entity<Category>().HasData(
                new Category() { CategoryId = 1, Name = "One Piece" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product() { ProductId = 1, Name = "One Piece Poster", Description = "A post from the anime One Piece", Price = new decimal(5.7), ImageURL = "/one_piece-poster.png" }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}