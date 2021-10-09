using System;
using System.Collections.Generic;
using System.Text;
using ThemeChange.Localization;
using Volo.Abp.Application.Services;

namespace ThemeChange
{
    /* Inherit your application services from this class.
     */
    public abstract class ThemeChangeAppService : ApplicationService
    {
        protected ThemeChangeAppService()
        {
            LocalizationResource = typeof(ThemeChangeResource);
        }
    }
}
