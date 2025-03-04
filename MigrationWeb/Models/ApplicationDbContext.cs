using Microsoft.EntityFrameworkCore;

namespace MigrationWeb.Models
{
   
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options) { }

            public DbSet<Product> Products { get; set; }
        }
    
}
