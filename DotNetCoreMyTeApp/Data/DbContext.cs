using DotNetCoreMyTeApp.Data;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<MyTimeTracking> MyTimeTrackings { get; set; }
}
