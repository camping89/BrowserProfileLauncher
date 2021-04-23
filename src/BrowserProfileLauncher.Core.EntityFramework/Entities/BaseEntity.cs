using System;

namespace BrowserProfileLauncher.Core.EntityFramework.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedTime = DateTime.UtcNow;
            ModifiedTime = DateTime.UtcNow;
        }
    }
}
