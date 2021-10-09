using ThemeChange.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ThemeChange.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ThemeChangeController : AbpController
    {
        protected ThemeChangeController()
        {
            LocalizationResource = typeof(ThemeChangeResource);
        }
    }
}