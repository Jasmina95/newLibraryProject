using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebAPICore.Dtos.Book;
using MyWebAPICore.Services.BookService;

namespace MyWebAPICore.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [AllowAnonymous]
        [HttpGet("Get")]
        public async Task<IActionResult> GetBooks()
        {
            return Ok(await _bookService.GetAllBooks());
        }

        [HttpGet("GetByTitle/{title}")]
        public async Task<IActionResult> GetBookByTitle(string title)
        {
            return Ok(await _bookService.GetBooksByTitle(title));
        }

        [HttpGet("BookById/{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            return Ok(await _bookService.GetBookById(id));
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddBook(AddBookDto newBook)
        {
            return Ok(await _bookService.AddBook(newBook));
        }

        [HttpPut("Update")]
        public async Task<IActionResult> UpdateBook(UpdateBookDto newBook)
        {
            return Ok(await _bookService.UpdateBook(newBook));
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            return Ok(await _bookService.DeleteBook(id));
        }

        [AllowAnonymous]
        [HttpPost("testTransaction")]
        public async Task<IActionResult> TestTrasanction()
        {
            return Ok(await _bookService.TestTransaction());
        }
    }
}
