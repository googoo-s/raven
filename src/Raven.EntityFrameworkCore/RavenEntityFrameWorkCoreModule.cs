using Volo.Abp.Modularity;
using Raven.Domain;
using Volo.Abp.EntityFrameworkCore.MySQL;
using Microsoft.Extensions.DependencyInjection;
using Raven.EntityFrameworkCore.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Raven.EntityFrameworkCore;

[DependsOn(
    typeof(RavenDomainModule),
    typeof(AbpEntityFrameworkCoreMySQLModule)
)]
public class RavenEntityFrameWorkCoreModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<RavenDbContext>(options =>
        {
            /* Remove "includeAllEntities: true" to create
             * default repositories only for aggregate roots */
            options.AddDefaultRepositories(includeAllEntities: true);
        });

        Configure<AbpDbContextOptions>(options =>
        {
            /* The main point to change your DBMS.
             * See also BookStoreMigrationsDbContextFactory for EF Core tooling. */
            options.UseMySQL();
        });
    }
}