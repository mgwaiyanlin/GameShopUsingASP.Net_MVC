using GameShopRazorPage.Models;
using Microsoft.EntityFrameworkCore;

namespace GameShopRazorPage.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Genre> Genres { get; set; }
    }
}
