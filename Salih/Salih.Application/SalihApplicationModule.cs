using System.Reflection;
using Abp.Modules;

namespace Salih
{
    [DependsOn(typeof(SalihCoreModule))]
    public class SalihApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
