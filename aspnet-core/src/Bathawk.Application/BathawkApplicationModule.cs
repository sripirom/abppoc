using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Bathawk.Authorization;

namespace Bathawk
{
    [DependsOn(
        typeof(BathawkCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BathawkApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<BathawkAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(BathawkApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
