using Microsoft.AspNetCore.Mvc;
using Starter.Application.Books;
using Starter.Application.Contracts.Books;

using Volo.Abp.Application.Dtos;

namespace Starter.HttpApi.Books;

[ApiController]
[Route("[Controller]")]
public class BookController : StarterController, IBookAppService
{
    private readonly IBookAppService _bookAppService;

    public BookController(IBookAppService bookAppService)
    {
        _bookAppService = bookAppService;
    }

    [HttpPost]
    public Task<BookDto> CreateAsync([FromBody] CreateUpdateBookDto input)
    {
        return _bookAppService.CreateAsync(input);
    }

    [HttpDelete("{id}")]
    public Task DeleteAsync([FromRoute(Name = "id")] Guid id)
    {
        return _bookAppService.DeleteAsync(id);
    }

    [HttpGet("{id}")]
    public Task<BookDto> GetAsync([FromRoute(Name = "id")] Guid id)
    {
        return _bookAppService.GetAsync(id);
    }

    [HttpGet("GetAuthorLookupAsync")]
    public Task<ListResultDto<AuthorLookupDto>> GetAuthorLookupAsync()
    {
        return _bookAppService.GetAuthorLookupAsync();
    }

    [HttpGet]
    public Task<PagedResultDto<BookDto>> GetListAsync([FromQuery] PagedAndSortedResultRequestDto input)
    {
        return _bookAppService.GetListAsync(input);
    }

    [HttpPut("{id}")]
    public Task<BookDto> UpdateAsync([FromRoute(Name = "id")] Guid id, [FromBody] CreateUpdateBookDto input)
    {
        return _bookAppService.UpdateAsync(id, input);
    }
}