using Microsoft.EntityFrameworkCore;

using Volo.Abp.EntityFrameworkCore;

namespace Starter.EntityFrameworkCore.EntityFrameworkCore;
public class StarterDbContext : AbpDbContext<StarterDbContext>
{
    public StarterDbContext(DbContextOptions<StarterDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(assembly: GetType().Assembly);
    }
}