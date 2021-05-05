using BrowserProfileLauncher.Common.Constants;
using BrowserProfileLauncher.Core.EntityFramework.DbContexts;
using BrowserProfileLauncher.Core.EntityFramework.Entities.Identities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserProfileLauncher.Core.EntityFramework.DbMigrators
{
    public class IdentityDbContextMigrator : DbMigratorBase<BrowserProfileLauncherIdentityDbContext>
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public IdentityDbContextMigrator(BrowserProfileLauncherIdentityDbContext dbContext,
                                        RoleManager<Role> roleManager,
                                        UserManager<User> userManager) : base(dbContext)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public override async Task MigrateAsync()
        {
            await base.MigrateAsync();
            await SeedIdentities();
        }

        private async Task SeedIdentities()
        {
            // Create admin role
            var roles = await _roleManager.Roles.ToListAsync();
            if (!roles.Any(x => x.Name == RoleNameConstants.AdminRole))
            {
                var role = new Role { Name = RoleNameConstants.AdminRole };

                await _roleManager.CreateAsync(role);
            }

            if (!roles.Any(x => x.Name == RoleNameConstants.UserRole))
            {
                var role = new Role { Name = RoleNameConstants.UserRole };

                await _roleManager.CreateAsync(role);
            }

            #region seed User data

            if (!await _dbContext.Users.AnyAsync())
            {
                var admin = new User
                {
                    UserName = "administrator",
                    Email = "tech.bifrost@gmail.com",
                    EmailConfirmed = true
                };

                var result = await _userManager.CreateAsync(admin, "Password123!");

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(admin, RoleNameConstants.AdminRole);
                }


                var user = new User
                {
                    UserName = "user_test",
                    Email = "truonganh88.2013@gmail.com",
                    EmailConfirmed = true
                };

                var adminResult = await _userManager.CreateAsync(user, "Password123!");

                if (adminResult.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, RoleNameConstants.UserRole);
                }
            }

            #endregion
        }
    }
}
