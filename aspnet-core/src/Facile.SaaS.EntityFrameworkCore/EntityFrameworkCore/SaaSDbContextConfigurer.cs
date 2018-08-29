using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Facile.SaaS.EntityFrameworkCore
{
    public static class SaaSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SaaSDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SaaSDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
