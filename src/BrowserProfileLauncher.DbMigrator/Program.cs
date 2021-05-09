using BrowserProfileLauncher.Core.EntityFramework.DbContexts;
using BrowserProfileLauncher.Core.EntityFramework.DbMigrators;
using BrowserProfileLauncher.Core.EntityFramework.Entities.Identities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace BrowserProfileLauncher.DbMigrator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                try
                {
                    var identityDbMigrator = scope.ServiceProvider.GetRequiredService<IDbMigrator<BrowserProfileLauncherIdentityDbContext>>();
                    await identityDbMigrator.MigrateAsync();

                    var browserProfileLauncherDbMigrator = scope.ServiceProvider.GetRequiredService<IDbMigrator<BrowserProfileLauncherDbContext>>();
                    await browserProfileLauncherDbMigrator.MigrateAsync();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
           Host.CreateDefaultBuilder(args)
               .ConfigureHostConfiguration(configHost =>
               {
                   configHost.AddEnvironmentVariables(prefix: "ASPNETCORE_");
               })
               .ConfigureAppConfiguration((context, builder) =>
               {
                   var env = context.HostingEnvironment;
                   builder.AddJsonFile("appsettings.json", optional: true);
                   builder.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);
               })
               .ConfigureServices((context, services) =>
               {
                   services.AddDbContext<BrowserProfileLauncherIdentityDbContext>(options => options.UseSqlServer(context.Configuration.GetConnectionString("IdentityDb")));
                   services.AddDbContext<BrowserProfileLauncherDbContext>(options => options.UseSqlServer(context.Configuration.GetConnectionString("BrowserProfileLauncher")));
                   services.AddIdentity<User, Role>(options =>
                   {
                       options.User.RequireUniqueEmail = true;
                       options.SignIn.RequireConfirmedEmail = true;
                       options.Password.RequireLowercase = false;
                       options.Password.RequireDigit = false;
                       options.Password.RequireNonAlphanumeric = false;
                       options.Password.RequiredLength = 6;
                       options.Password.RequireUppercase = false;
                       options.Password.RequiredUniqueChars = 0;
                   }).AddEntityFrameworkStores<BrowserProfileLauncherIdentityDbContext>()
                     .AddDefaultTokenProviders();

                   services.AddScoped<IDbMigrator<BrowserProfileLauncherIdentityDbContext>, IdentityDbContextMigrator>();
                   services.AddScoped<IDbMigrator<BrowserProfileLauncherDbContext>, BrowserProfileLauncherDbContextMigrator>();
               })
              .UseConsoleLifetime();
    }
}
