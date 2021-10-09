using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ThemeChange.Data
{
    /* This is used if database provider does't define
     * IThemeChangeDbSchemaMigrator implementation.
     */
    public class NullThemeChangeDbSchemaMigrator : IThemeChangeDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}