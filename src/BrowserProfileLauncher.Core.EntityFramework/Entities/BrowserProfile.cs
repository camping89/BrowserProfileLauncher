using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrowserProfileLauncher.Core.EntityFramework.Entities
{
    public class BrowserProfile : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid? GroupId { get; set; }
        public string ProfileName { get; set; }
        public string ProxyIp { get; set; }
        public int ProxyPort { get; set; }
        public string ProxyProtocol { get; set; }
        public string ProxyUsername { get; set; }
        public string ProxyPassword { get; set; }

        [ForeignKey(nameof(GroupId))]
        public virtual ProfileGroup Group { get; set; }
    }
}
