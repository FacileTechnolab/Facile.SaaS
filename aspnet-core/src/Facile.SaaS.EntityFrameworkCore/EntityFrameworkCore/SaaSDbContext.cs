using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Facile.SaaS.Authorization.Roles;
using Facile.SaaS.Authorization.Users;
using Facile.SaaS.MultiTenancy;

namespace Facile.SaaS.EntityFrameworkCore
{
    public class SaaSDbContext : AbpZeroDbContext<Tenant, Role, User, SaaSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SaaSDbContext(DbContextOptions<SaaSDbContext> options)
            : base(options)
        {
        }
    }
}
