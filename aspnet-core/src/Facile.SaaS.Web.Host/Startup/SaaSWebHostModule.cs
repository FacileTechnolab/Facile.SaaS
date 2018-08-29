using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Facile.SaaS.Configuration;

namespace Facile.SaaS.Web.Host.Startup
{
    [DependsOn(
       typeof(SaaSWebCoreModule))]
    public class SaaSWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SaaSWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SaaSWebHostModule).GetAssembly());
        }
    }
}
