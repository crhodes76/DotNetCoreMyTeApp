using Microsoft.EntityFrameworkCore;

namespace DotNetCoreMyTeApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<MyTimeTracking> MyTimeTrackings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MyTimeTracking>(entity =>
            {
                entity.ToTable("MyTimeTracking");
                entity.HasKey(e => e.Id); // Define the primary key
            });

            // Ensure List<string> is not treated as an entity
            modelBuilder.Ignore<List<string>>();
        }
    }
}