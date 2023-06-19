using System.ComponentModel.DataAnnotations;
using Starter.Domain.Shared.Authors;

namespace Starter.Application.Contracts.Authors;
public class CreateAuthorDto
{
    [Required]
    [StringLength(AuthorConsts.MaxNameLength)]
    public string Name { get; set; } = null!;

    [Required]
    public DateTime BirthDate { get; set; }

    public string ShortBio { get; set; } = null!;
}