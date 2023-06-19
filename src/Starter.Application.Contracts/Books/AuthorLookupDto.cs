using System;
using Volo.Abp.Application.Dtos;

namespace Starter.Application.Contracts.Books;
public class AuthorLookupDto : EntityDto<Guid>
{
    public string Name { get; set; }
}