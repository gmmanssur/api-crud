using Integration.Entity;
using Microsoft.EntityFrameworkCore;

namespace Integration
{
    public class HomeIntegration : DbContext
    {
        public HomeIntegration(DbContextOptions<HomeIntegration> options) : base(options) { }

        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
