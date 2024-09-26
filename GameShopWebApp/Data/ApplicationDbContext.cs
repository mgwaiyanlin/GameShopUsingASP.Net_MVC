using GameShopWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GameShopWebApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Platforms> GamePlatforms { get; set; }

        // Database seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Action"},
                new Genre { Id = 2, Name = "Adventure"},
                new Genre { Id = 3, Name = "Horror"},
                new Genre { Id = 4, Name = "Racing"},
                new Genre { Id = 5, Name = "Shooter" }
            );
        }
    }
    
}
