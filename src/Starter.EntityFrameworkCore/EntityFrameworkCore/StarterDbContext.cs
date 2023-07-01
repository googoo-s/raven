using Microsoft.EntityFrameworkCore;
using Starter.Domain.Authors;
using Starter.Domain.Books;
using Volo.Abp.EntityFrameworkCore;

namespace Starter.EntityFrameworkCore.EntityFrameworkCore;
public class StarterDbContext : AbpDbContext<StarterDbContext>
{
    public DbSet<Book> Books { get; set; }

    public DbSet<Author> Authors { get; set; }

    public StarterDbContext(DbContextOptions<StarterDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(assembly: GetType().Assembly);
    }
}