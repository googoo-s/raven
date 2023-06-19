using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Starter.Application.Contracts.Authors;
public class GetAuthorListDto : PagedAndSortedResultRequestDto
{
    public string? Filter { get; set; }
}