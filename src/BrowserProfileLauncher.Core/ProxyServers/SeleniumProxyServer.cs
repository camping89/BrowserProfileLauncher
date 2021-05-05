using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Titanium.Web.Proxy;
using Titanium.Web.Proxy.EventArguments;
using Titanium.Web.Proxy.Models;

namespace BrowserProfileLauncher.Core.ProxyServers
{
    public interface ISeleniumProxyServer
    {
        void LaunchBrowser(ProxyAuth auth, string customAgent = null);
    }

    public class SeleniumProxyServer : ISeleniumProxyServer, IDisposable
    {
        private Dictionary<int, ProxyAuth> proxyAuths;
        private ProxyServer proxyServer;

        public SeleniumProxyServer()
        {
            proxyAuths = new Dictionary<int, ProxyAuth>();
            proxyServer = new ProxyServer();
            proxyServer.BeforeRequest += OnRequest;
            proxyServer.Start();
        }

        public void LaunchBrowser(ProxyAuth auth, string customAgent = null)
        {
            var agent = customAgent ?? "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Safari/537.36";
            var localPort = AddEndpoint(auth);

            var options = new ChromeOptions();

            options.AddArgument($"--proxy-server=127.0.0.1:{localPort}");
            options.AddArgument("--start-maximized");
            options.AddArgument("--ignore-ssl-errors=yes");
            options.AddArgument("--ignore-certificate-errors");
            options.AddArgument("--disable-web-security");
            options.AddArgument("--allow-running-insecure-content");

            options.AcceptInsecureCertificates = true;
            options.AddArgument("--disable-blink-features=AutomationControlled");
            options.AddArgument($"user-agent={agent}");

            options.AddExcludedArgument("enable-automation");
            options.AddAdditionalCapability("useAutomationExtension", false);

            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            var driver = new ChromeDriver(service, options);

            driver.Navigate().GoToUrl("https://myip.com/");
            try
            {
                var js = (IJavaScriptExecutor)driver;
                string title2 = (string)js.ExecuteScript($"document.title = '{auth.Proxy}:{auth.Port}'");
            }
            catch { }
        }

        /// <summary>
        /// Adds a new endpoint to the local proxy server
        /// </summary>
        /// <param name="auth">ProxyAuth</param>
        /// <returns>Port where the new proxy will be opened</returns>
        private int AddEndpoint(ProxyAuth auth)
        {
            var ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            var conArr = ipGlobalProperties.GetActiveTcpListeners();

            for (int i = 50000; i < 60000; i++)
            {
                if (conArr.Any(x => x.Port == i)) continue;

                proxyServer.AddEndPoint(new ExplicitProxyEndPoint(IPAddress.Any, i, true));

                proxyAuths.Add(i, auth);
                return i;
            }
            throw new Exception("Couldn't find any available tcp port!");
        }

        /// <summary>
        /// When a new request is received, set up the upstream proxy based on the port of the request
        /// </summary>
        private async Task OnRequest(object sender, SessionEventArgs e)
        {
            if (!proxyAuths.TryGetValue(e.ClientLocalEndPoint.Port, out var auth))
            {
                e.Ok("<html><h>Error with proxy</h></html>");
                return;
            }

            e.CustomUpStreamProxy = new ExternalProxy(auth.Proxy, auth.Port, auth.Username, auth.Password)
            {
                ProxyType = ExternalProxyType.Http
            };
        }

        /// <summary>
        /// Dispose the proxy server
        /// </summary>
        public void Dispose()
        {
            proxyServer.Dispose();
        }
    }
}
