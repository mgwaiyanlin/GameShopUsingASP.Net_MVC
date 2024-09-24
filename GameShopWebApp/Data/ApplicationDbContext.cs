using Microsoft.EntityFrameworkCore;

namespace GameShopWebApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        
    }
}
