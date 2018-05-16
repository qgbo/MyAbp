using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Acme.SimpleTaskApp.Configuration;

namespace Acme.SimpleTaskApp.Web.Host.Startup
{
    [DependsOn(
       typeof(SimpleTaskAppWebCoreModule))]
    public class SimpleTaskAppWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SimpleTaskAppWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SimpleTaskAppWebHostModule).GetAssembly());
        }
    }
}
