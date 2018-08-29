using System.Threading.Tasks;
using Facile.SaaS.Configuration.Dto;

namespace Facile.SaaS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
