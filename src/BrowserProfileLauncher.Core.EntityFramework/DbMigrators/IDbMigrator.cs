using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BrowserProfileLauncher.Core.EntityFramework.DbMigrators
{
    public interface IDbMigrator<TContext> where TContext : DbContext
    {
        Task MigrateAsync();
    }
}
