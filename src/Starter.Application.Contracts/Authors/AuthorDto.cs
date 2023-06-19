using Volo.Abp.Application.Dtos;

namespace Starter.Application.Contracts.Authors;
public class AuthorDto : EntityDto<Guid>
{
    public string Name { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    public string ShortBio { get; set; } = null!;
}