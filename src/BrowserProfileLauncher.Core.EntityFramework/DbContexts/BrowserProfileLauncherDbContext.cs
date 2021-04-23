using BrowserProfileLauncher.Core.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace BrowserProfileLauncher.Core.EntityFramework.DbContexts
{
    public class BrowserProfileLauncherDbContext : DbContext
    {
        public DbSet<BrowserProfile> BrowserProfiles { get; set; }
        public DbSet<ProfileGroup> ProfileGroups { get; set; }

        public BrowserProfileLauncherDbContext(DbContextOptions<BrowserProfileLauncherDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<BrowserProfile>().ToTable("BrowserProfiles");
            builder.Entity<ProfileGroup>().ToTable("ProfileGroups");
        }
    }
}
