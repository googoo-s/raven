using AutoMapper;
using Starter.Application.Contracts.Authors;
using Starter.Application.Contracts.Books;
using Starter.Domain.Authors;
using Starter.Domain.Books;

namespace Starter.Application;

public class StarterApplicationAutoMapperProfile : Profile
{
    public StarterApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        // todo mapper
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<Author, AuthorDto>();
        CreateMap<Author, AuthorLookupDto>();
    }
}