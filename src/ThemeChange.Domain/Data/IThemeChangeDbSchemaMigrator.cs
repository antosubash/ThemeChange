using System.Threading.Tasks;

namespace ThemeChange.Data
{
    public interface IThemeChangeDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
