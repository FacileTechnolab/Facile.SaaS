using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Facile.SaaS.MultiTenancy.Dto;

namespace Facile.SaaS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
