using MyWebAPICore.Dtos.Book;
using MyWebAPICore.Models;

namespace MyWebAPICore.Services.BookService
{
    public interface IBookService
    {
        Task<ICollection<GetBookDto>> GetAllBooks();
        Task<ICollection<GetBookDto>> GetBooksByTitle(string title);
        Task<GetBookDto> GetBookById(int id);
        Task<ICollection<GetBookDto>> AddBook(AddBookDto newBook);
        Task<GetBookDto> UpdateBook(UpdateBookDto updatedBook);
        Task<ICollection<GetBookDto>> DeleteBook(int id);
        Task<ICollection<GetBookDto>> TestTransaction();
    }
}
