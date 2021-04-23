using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BrowserProfileLauncher.Core.EntityFramework.DbMigrators
{
    public class DbMigratorBase<TContext> : IDbMigrator<TContext> where TContext : DbContext
    {
        protected readonly TContext _dbContext;

        public DbMigratorBase(TContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}
