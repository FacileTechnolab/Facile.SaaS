using System.Threading.Tasks;
using Abp.Application.Services;
using Facile.SaaS.Sessions.Dto;

namespace Facile.SaaS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
