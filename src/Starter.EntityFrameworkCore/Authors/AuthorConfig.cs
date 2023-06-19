using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Starter.Domain.Authors;
using Starter.Domain.Shared.Authors;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Starter.EntityFrameworkCore.Authors;
public class AuthorConfig : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.ToTable("Authors");

        builder.ConfigureByConvention();

        builder.Property(x => x.Name).IsRequired().HasMaxLength(AuthorConsts.MaxNameLength);

        builder.HasIndex(x => x.Name);
    }
}