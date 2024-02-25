using Test.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Test.Infrastructure
{
    public class AppDbContextSeed
    {
        public static async Task Seed(
            AppDbContext appDbContext,
            ILogger logger)
        {
            if (appDbContext.Database.IsMySql())
                await appDbContext.Database.MigrateAsync();
        }
    }
}
