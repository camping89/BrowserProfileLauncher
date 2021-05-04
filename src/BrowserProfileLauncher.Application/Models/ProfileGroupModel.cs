using System;

namespace BrowserProfileLauncher.Application.Models
{
    public class ProfileGroupModel
    {
        public Guid Id { get; set; }
        public string GroupName { get; set; }
        public int ProfilesCount { get; set; }
    }
}
