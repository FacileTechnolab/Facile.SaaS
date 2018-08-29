using Abp.MultiTenancy;
using Facile.SaaS.Authorization.Users;

namespace Facile.SaaS.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
