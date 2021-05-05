using BrowserProfileLauncher.Core.EntityFramework.DbContexts;
using BrowserProfileLauncher.Core.EntityFramework.Entities;
using BrowserProfileLauncher.Core.EntityFramework.Entities.Identities;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserProfileLauncher.Core.EntityFramework.DbMigrators
{
    public class BrowserProfileLauncherDbContextMigrator : DbMigratorBase<BrowserProfileLauncherDbContext>
    {
        private readonly UserManager<User> _userManager;
        public BrowserProfileLauncherDbContextMigrator(BrowserProfileLauncherDbContext dbContext,
                                                       UserManager<User> userManager) : base(dbContext)
        {
            _userManager = userManager;
        }
        public override async Task MigrateAsync()
        {
            await base.MigrateAsync();
            await SeedBrowserProfiles();
        }

        private async Task SeedBrowserProfiles()
        {
            //create profile groups
            if (!_dbContext.ProfileGroups.Any())
            {
                await _dbContext.ProfileGroups.AddAsync(new ProfileGroup
                {
                    GroupName = "Group 1"
                });
                await _dbContext.SaveChangesAsync();
            }

            // Create browser profiles
            if (!_dbContext.BrowserProfiles.Any())
            {
                var user = _userManager.Users.FirstOrDefault();
                var group = _dbContext.ProfileGroups.FirstOrDefault();
                if (user != null)
                {
                    var proxyIps = new List<string> { "181.215.158.143", "154.16.135.66", "154.127.52.12", "185.33.85.117", "154.16.213.103" };
                    var browserProfiles = proxyIps.Select((proxyIp, index) => new BrowserProfile
                    {
                        ProfileName = $"{user.UserName} {index + 1}",
                        ProxyIp = proxyIp,
                        ProxyPort = 34512,
                        ProxyProtocol = "https",
                        ProxyUsername = "proxyK6",
                        ProxyPassword = "L8i3GlX",
                        UserId = user.Id,
                        GroupId = group?.Id
                    });

                    await _dbContext.BrowserProfiles.AddRangeAsync(browserProfiles);
                    await _dbContext.SaveChangesAsync();
                };
            }
        }
    }
}
