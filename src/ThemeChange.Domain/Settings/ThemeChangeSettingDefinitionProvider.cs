using Volo.Abp.Settings;

namespace ThemeChange.Settings
{
    public class ThemeChangeSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ThemeChangeSettings.MySetting1));
        }
    }
}
