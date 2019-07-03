using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using CAGLAR.EntityFramework;

namespace CAGLAR.Migrator
{
    [DependsOn(typeof(CAGLARDataModule))]
    public class CAGLARMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<CAGLARDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}