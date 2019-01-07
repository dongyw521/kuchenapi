using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using kuchen.Authorization;

namespace kuchen
{
    [DependsOn(
        typeof(kuchenCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class kuchenApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<kuchenAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(kuchenApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
