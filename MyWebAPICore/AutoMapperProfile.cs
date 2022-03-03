using AutoMapper;
using MyWebAPICore.Dtos.Author;
using MyWebAPICore.Dtos.AuthorBook;
using MyWebAPICore.Dtos.Book;
using MyWebAPICore.Dtos.Publisher;
using MyWebAPICore.Models;

namespace MyWebAPICore
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Book, GetBookDto>()
                .ForMember(dto => dto.Authors, b => b.MapFrom(b => b.AuthorBooks.Select(ab => ab.Author)));
            CreateMap<Publisher, GetPublisherDto>();
            CreateMap<Author, GetAuthorDto>();
            CreateMap<AddAuthorBookDto, AuthorBook>();
            CreateMap<AddBookDto, Book>();
        }
    }
}
