using ThemeChange.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ThemeChange
{
    [DependsOn(
        typeof(ThemeChangeEntityFrameworkCoreTestModule)
        )]
    public class ThemeChangeDomainTestModule : AbpModule
    {

    }
}