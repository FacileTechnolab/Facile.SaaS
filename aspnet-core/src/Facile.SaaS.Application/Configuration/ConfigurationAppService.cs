using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Facile.SaaS.Configuration.Dto;

namespace Facile.SaaS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SaaSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
