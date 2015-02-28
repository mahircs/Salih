using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace Salih
{
    [DependsOn(typeof(AbpWebApiModule), typeof(SalihApplicationModule))]
    public class SalihWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(SalihApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
