using Volo.Abp.Modularity;

namespace ThemeChange
{
    [DependsOn(
        typeof(ThemeChangeApplicationModule),
        typeof(ThemeChangeDomainTestModule)
        )]
    public class ThemeChangeApplicationTestModule : AbpModule
    {

    }
}