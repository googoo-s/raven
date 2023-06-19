using Volo.Abp.Application.Dtos;

namespace Starter.Application.Contracts.Authors;
public interface IAuthorAppService
{
    Task<AuthorDto> GetAsync(Guid id);

    Task<PagedResultDto<AuthorDto>> GetListAsync(GetAuthorListDto input);

    Task<AuthorDto> CreateAsync(CreateAuthorDto input);

    Task UpdateAsync(Guid id, UpdateAuthorDto input);

    Task DeleteAsync(Guid id);
}