using Abp.Authorization;
using Facile.SaaS.Authorization.Roles;
using Facile.SaaS.Authorization.Users;

namespace Facile.SaaS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
