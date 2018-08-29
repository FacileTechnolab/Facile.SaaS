using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Facile.SaaS.Configuration;
using Facile.SaaS.Web;

namespace Facile.SaaS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SaaSDbContextFactory : IDesignTimeDbContextFactory<SaaSDbContext>
    {
        public SaaSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SaaSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SaaSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SaaSConsts.ConnectionStringName));

            return new SaaSDbContext(builder.Options);
        }
    }
}
