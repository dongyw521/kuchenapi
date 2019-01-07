using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using kuchen.Configuration;

namespace kuchen.Web.Host.Startup
{
    [DependsOn(
       typeof(kuchenWebCoreModule))]
    public class kuchenWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public kuchenWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(kuchenWebHostModule).GetAssembly());
        }
    }
}
