﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Acme.SimpleTaskApp.Configuration;

namespace Acme.SimpleTaskApp.Web.Startup
{
    [DependsOn(typeof(SimpleTaskAppWebCoreModule))]
    public class SimpleTaskAppWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SimpleTaskAppWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<SimpleTaskAppNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SimpleTaskAppWebMvcModule).GetAssembly());
        }
    }
}
