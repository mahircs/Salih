using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using Salih.EntityFramework;

namespace Salih
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(SalihCoreModule))]
    public class SalihDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<SalihDbContext>(null);
        }
    }
}
