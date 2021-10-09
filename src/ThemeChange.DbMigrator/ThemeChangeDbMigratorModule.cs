using ThemeChange.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ThemeChange.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ThemeChangeEntityFrameworkCoreModule),
        typeof(ThemeChangeApplicationContractsModule)
        )]
    public class ThemeChangeDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
