using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ThemeChange.Web
{
    [Dependency(ReplaceServices = true)]
    public class ThemeChangeBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ThemeChange";
    }
}
