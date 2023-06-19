using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Starter.Domain.Authors;
using Starter.Domain.Books;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Starter.EntityFrameworkCore.Books;
public class BookConfig : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("Books");
        //auto configure for the base class props
        builder.ConfigureByConvention();
        builder.Property(x => x.Name).IsRequired().HasMaxLength(128);
        builder.HasOne<Author>().WithMany().HasForeignKey(x => x.AuthorId).IsRequired();
    }
}