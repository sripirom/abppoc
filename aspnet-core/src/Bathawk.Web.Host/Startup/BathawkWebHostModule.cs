using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Bathawk.Configuration;

namespace Bathawk.Web.Host.Startup
{
    [DependsOn(
       typeof(BathawkWebCoreModule))]
    public class BathawkWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public BathawkWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BathawkWebHostModule).GetAssembly());
        }
    }
}
