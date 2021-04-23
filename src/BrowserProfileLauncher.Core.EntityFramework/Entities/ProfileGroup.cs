using System.Collections.Generic;

namespace BrowserProfileLauncher.Core.EntityFramework.Entities
{
    public class ProfileGroup : BaseEntity
    {
        public string GroupName { get; set; }
        public virtual ICollection<BrowserProfile> BrowserProfiles { get; set; }
    }
}
