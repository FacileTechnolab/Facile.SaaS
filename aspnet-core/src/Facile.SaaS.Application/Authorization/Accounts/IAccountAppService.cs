using System.Threading.Tasks;
using Abp.Application.Services;
using Facile.SaaS.Authorization.Accounts.Dto;

namespace Facile.SaaS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
