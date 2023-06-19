using Microsoft.AspNetCore.Mvc;
using Starter.Application.Contracts.Authors;

using Volo.Abp.Application.Dtos;

namespace Starter.HttpApi.Authors;
[ApiController]
[Route("[Controller]")]
public class AuthorController : StarterController, IAuthorAppService
{
    private readonly IAuthorAppService _authorAppService;
    public AuthorController(IAuthorAppService authorAppService)
    {
        _authorAppService = authorAppService;
    }

    [HttpPost]
    public Task<AuthorDto> CreateAsync([FromBody] CreateAuthorDto input)
    {
        return _authorAppService.CreateAsync(input);
    }

    [HttpDelete("{id}")]
    public Task DeleteAsync([FromRoute(Name = "id")] Guid id)
    {
        return _authorAppService.DeleteAsync(id);
    }

    [HttpGet("{id}")]
    public Task<AuthorDto> GetAsync([FromRoute(Name = "id")] Guid id)
    {
        return _authorAppService.GetAsync(id);
    }

    [HttpGet]
    public Task<PagedResultDto<AuthorDto>> GetListAsync([FromQuery] GetAuthorListDto input)
    {
        return _authorAppService.GetListAsync(input: input);
    }

    [HttpPut("{id}")]
    public Task UpdateAsync([FromRoute(Name = "id")] Guid id, [FromBody] UpdateAuthorDto input)
    {
        return _authorAppService.UpdateAsync(id, input);
    }
}