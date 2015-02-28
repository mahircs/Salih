using System.Reflection;
using Abp.Modules;

namespace Salih
{
    public class SalihCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
