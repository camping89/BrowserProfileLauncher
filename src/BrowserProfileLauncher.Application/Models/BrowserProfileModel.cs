using System;

namespace BrowserProfileLauncher.Application.Models
{
    public class BrowserProfileModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid? GroupId { get; set; }
        public string GroupName { get; set; }
        public string ProfileName { get; set; }
        public string ProxyIp { get; set; }
        public int? ProxyPort { get; set; }
        public string ProxyProtocol { get; set; }
        public string ProxyUsername { get; set; }
        public string ProxyPassword { get; set; }
    }
}
