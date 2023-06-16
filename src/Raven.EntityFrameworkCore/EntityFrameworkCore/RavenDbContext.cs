using Microsoft.EntityFrameworkCore;

using Volo.Abp.EntityFrameworkCore;

namespace Raven.EntityFrameworkCore.EntityFrameworkCore;
public class RavenDbContext : AbpDbContext<RavenDbContext>
{
    public RavenDbContext(DbContextOptions<RavenDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(assembly: GetType().Assembly);
    }
}