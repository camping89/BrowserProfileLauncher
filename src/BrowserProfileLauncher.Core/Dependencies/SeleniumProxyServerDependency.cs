using BrowserProfileLauncher.Core.ProxyServers;
using Microsoft.Extensions.DependencyInjection;

namespace BrowserProfileLauncher.Core.Dependencies
{
    public static class SeleniumProxyServerDependency
    {
        public static IServiceCollection UseSeleniumProxyServer(this IServiceCollection services)
        {
            services.AddScoped<ISeleniumProxyServer, SeleniumProxyServer>();
            return services;
        }
    }
}
