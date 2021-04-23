using System;
using System.Collections.Generic;

namespace BrowserProfileLauncher.Application.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public IList<Guid> ProfileGroupIds { get; set; }
        public IList<string> RoleNames { get; set; }
    }
}
