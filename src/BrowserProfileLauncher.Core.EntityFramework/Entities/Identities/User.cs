using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrowserProfileLauncher.Core.EntityFramework.Entities.Identities
{
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AvatarUrl { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                var fullName = $"{FirstName} {LastName}";
                return string.IsNullOrWhiteSpace(fullName.Trim()) ? UserName : fullName;
            }
        }
    }
}
