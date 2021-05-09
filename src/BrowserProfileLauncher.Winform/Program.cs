using Arch.EntityFrameworkCore.UnitOfWork;
using AutoMapper;
using BrowserProfileLauncher.Application.MapperProfiles;
using BrowserProfileLauncher.Core.Dependencies;
using BrowserProfileLauncher.Core.EntityFramework.DbContexts;
using BrowserProfileLauncher.Core.EntityFramework.Entities.Identities;
using BrowserProfileLauncher.Services.Accounts;
using BrowserProfileLauncher.Services.BrowserProfiles;
using BrowserProfileLauncher.Services.ProfileGroups;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Windows.Forms;
using WinformApplication = System.Windows.Forms.Application;

namespace BrowserProfileLauncher.Winform
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WinformApplication.SetHighDpiMode(HighDpiMode.SystemAware);
            WinformApplication.EnableVisualStyles();
            WinformApplication.SetCompatibleTextRenderingDefault(false);

            using var scope = ConfigureServiceScope();
            var services = scope.ServiceProvider;
            var loginForm = services.GetRequiredService<LoginForm>();
            try
            {
                WinformApplication.Run(loginForm);
            }
            catch (Exception)
            {

                WinformApplication.Exit();
            }

        }

        private static IServiceScope ConfigureServiceScope()
        {
            var host = new HostBuilder()
                       .ConfigureAppConfiguration((context, builder) =>
                       {
                           builder.AddJsonFile("appsettings.json", optional: true);
                       })
                       .ConfigureServices((context, services) =>
                       {
                           services.AddDbContext<BrowserProfileLauncherIdentityDbContext>(options => options.UseSqlServer(context.Configuration.GetConnectionString("IdentityDb")));
                           services.AddDbContext<BrowserProfileLauncherDbContext>(options => options.UseSqlServer(context.Configuration.GetConnectionString("BrowserProfileLauncher")))
                                   .AddUnitOfWork<BrowserProfileLauncherDbContext, BrowserProfileLauncherIdentityDbContext>();

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

                           var mapperConfig = new MapperConfiguration(mc =>
                           {
                               mc.AddProfile(new BrowserProfileMapperProfile());
                               mc.AddProfile(new UserMapperProfile());
                               mc.AddProfile(new ProfileGroupMapperProfile());
                           });

                           var mapper = mapperConfig.CreateMapper();
                           services.AddSingleton(mapper);

                           services.UseSeleniumProxyServer();

                           services.AddSingleton<LoginForm>()
                                   .AddScoped<IAccountService, AccountService>()
                                   .AddScoped<IBrowserProfileService, BrowserProfileService>()
                                   .AddScoped<IProfileGroupService, ProfileGroupService>()
                                   .AddSingleton<IServiceProvider>(services.BuildServiceProvider())
                                   .AddLogging(configure => configure.AddConsole());
                       });

            return host.Build().Services.CreateScope();
        }
    }
}
