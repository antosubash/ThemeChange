using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ThemeChange.Data;
using Volo.Abp.DependencyInjection;

namespace ThemeChange.EntityFrameworkCore
{
    public class EntityFrameworkCoreThemeChangeDbSchemaMigrator
        : IThemeChangeDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreThemeChangeDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ThemeChangeDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ThemeChangeDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
