using Volo.Abp.Modularity;
using Volo.Abp.EntityFrameworkCore.MySQL;
using Microsoft.Extensions.DependencyInjection;
using Starter.EntityFrameworkCore.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;


namespace Starter.EntityFrameworkCore;

[DependsOn(
    typeof(StarterDomainModule),
    typeof(AbpEntityFrameworkCoreMySQLModule)
)]
public class StarterEntityFrameworkCoreModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        _ = context.Services.AddAbpDbContext<StarterDbContext>(options =>
        {
            /* Remove "includeAllEntities: true" to create
             * default repositories only for aggregate roots */
            _ = options.AddDefaultRepositories(includeAllEntities: true);
        });

        Configure<AbpDbContextOptions>(options =>
        {
            /* The main point to change your DBMS.
             * See also StarterMigrationsDbContextFactory for EF Core tooling. */
            options.UseMySQL();
        });
    }
}