using ThemeChange.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ThemeChange.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ThemeChangePageModel : AbpPageModel
    {
        protected ThemeChangePageModel()
        {
            LocalizationResourceType = typeof(ThemeChangeResource);
        }
    }
}