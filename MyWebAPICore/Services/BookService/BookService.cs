using AutoMapper;
using EntityFramework.Exceptions.Common;
using Hangfire;
using Microsoft.EntityFrameworkCore;
using MyWebAPICore.Data;
using MyWebAPICore.Dtos.Book;
using MyWebAPICore.ExceptionHandler;
using MyWebAPICore.Models;

namespace MyWebAPICore.Services.BookService
{
    public class BookService : IBookService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public BookService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ICollection<GetBookDto>> AddBook(AddBookDto newBook)
        {
            var transaction = _context.Database.BeginTransaction();

            var errors = new Dictionary<ValidationErrorCode, string>();

            Book book = _mapper.Map<Book>(newBook);
            var publisher = await _context.Publishers.FirstOrDefaultAsync(p => p.Id == newBook.PublisherId);
            
            if (publisher != null)
            {
                book.Publisher = publisher;
            }
            _context.Books.Add(book);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (UniqueConstraintException ex)
            {
                transaction.Rollback();
                errors.Add(ValidationErrorCode.CreateBookTitle, $"{ex.Message}: Book title already exists!");
                throw new BookServiceExceptionHandler(errors);
            }
            catch(ReferenceConstraintException ex)
            {
                transaction?.Rollback();
                errors.Add(ValidationErrorCode.ReferenceAuthorsAndPublisher, $"{ex.Message}: Publisher doesn't exist in the database!");
                throw new BookServiceExceptionHandler(errors);
            }
            
            var savedBook = await _context.Books.FirstOrDefaultAsync(b => b.Title == newBook.Title);

            if (savedBook != null)
            {
                foreach (int authorId in newBook.Authors)
                {
                    _context.AuthorBooks.Add(new AuthorBook() { BookId = savedBook.Id, AuthorId = authorId });
                    try
                    {
                        await _context.SaveChangesAsync();
                    } catch (ReferenceConstraintException ex)
                    {
                        transaction.Rollback();
                        errors.Add(ValidationErrorCode.ReferenceAuthorsAndPublisher, $"{ex.Message}: Check author ids! Some of them might not exist in the database.");
                        throw new BookServiceExceptionHandler(errors);
                    }
              
                }
            }
            
            transaction.Commit();
            return await _context.Books
                .Include(b => b.Publisher)
                .Include(b => b.AuthorBooks)
                .ThenInclude(ab => ab.Author)
                .Select(b => _mapper.Map<GetBookDto>(b))
                .ToListAsync(); ;
        }

        public async Task<ICollection<GetBookDto>> DeleteBook(int id)
        {

                var book = await _context.Books.FirstOrDefaultAsync(b => b.Id == id);

                if (book != null)
                {
                    _context.Books.Remove(book);
                    await _context.SaveChangesAsync();

                    return await _context.Books
                        .Include(b => b.Publisher)
                        .Include(b => b.AuthorBooks)
                        .ThenInclude(ab => ab.Author)
                        .Select(b => _mapper.Map<GetBookDto>(b))
                        .ToListAsync();
                }
                {
                    var errors = new Dictionary<ValidationErrorCode, string>();

                    errors.Add(ValidationErrorCode.BookNotFound, "Book not found!");
                    throw new BookServiceExceptionHandler(errors);
                }
            
        }

        public async Task<ICollection<GetBookDto>> GetAllBooks()
        {
            //BackgroundJob.Schedule(() => Console.WriteLine("Get Books job"), TimeSpan.FromSeconds(10));
            var dbBooks = await _context.Books
                .Include(b => b.Publisher)
                .Include(b => b.AuthorBooks)
                .ThenInclude(ab => ab.Author)
                .ToListAsync();

            return dbBooks.Select(b => _mapper.Map<GetBookDto>(b)).ToList();
        }

        public async Task<GetBookDto> GetBookById(int id)
        {
            var dbBook = await _context.Books
                .Include(b => b.Publisher)
                .Include(b => b.AuthorBooks)
                .ThenInclude(ab => ab.Author)
                .FirstOrDefaultAsync(b => b.Id == id);

            if (dbBook != null)
            {
                return _mapper.Map<GetBookDto>(dbBook);
            } else
            {
                var errors = new Dictionary<ValidationErrorCode, string>();
                errors.Add(ValidationErrorCode.BookNotFound, "Book not found!");
                throw new BookServiceExceptionHandler(errors);
            }
        }

        public async Task<ICollection<GetBookDto>> GetBooksByTitle(string title)
        {
            var dbBooks = await _context.Books.Where(b => b.Title == title).ToListAsync();

            return dbBooks.Select(b => _mapper.Map<GetBookDto>(b)).ToList();

        }

        public async Task<ICollection<GetBookDto>> TestTransaction()
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                var publisher = await _context.Publishers.FirstOrDefaultAsync(p => p.Id == 1);
                ICollection<int> authors = new List<int>() { 1, 2 };

                if (publisher != null)
                {
                    Book book = new Book()
                    {
                        Title = "New Book Title3",
                        Description = "New book description",
                        Pages = 50,
                        Price = 10.50,
                        Publisher = publisher
                    };

                    _context.Books.Add(book);
                    await _context.SaveChangesAsync();

                    var savedBook = await _context.Books.FirstOrDefaultAsync(b => b.Title == book.Title);

                    foreach (int authorId in authors)
                    {
                        _context.AuthorBooks.Add(new AuthorBook() { BookId = savedBook.Id, AuthorId = authorId });
                        await _context.SaveChangesAsync();
                    }

                    Book book2 = new Book()
                    {
                        Title = "New Book Title",
                        Description = "New book description",
                        Pages = 0,
                        Price = 10.50,
                        Publisher = publisher
                    };

                    _context.Books.Add(book2);
                    await _context.SaveChangesAsync();

                    var savedBook2 = await _context.Books.FirstOrDefaultAsync(b => b.Title == "New Book Title");

                    foreach (int authorId in authors)
                    {
                        _context.AuthorBooks.Add(new AuthorBook() { BookId = savedBook2.Id, AuthorId = authorId });
                        await _context.SaveChangesAsync();
                    }

                }

                transaction.Commit();

                return await _context.Books
                    .Include(b => b.Publisher)
                    .Include(b => b.AuthorBooks)
                    .ThenInclude(ab => ab.Author)
                    .Select(b => _mapper.Map<GetBookDto>(b))
                    .ToListAsync();

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new TransactionExceptionHandler($"Something went wrong: {ex.Message}");
            }
        }

        public async Task<GetBookDto> UpdateBook(UpdateBookDto updatedBook)
        {
            var transaction = _context.Database.BeginTransaction();
            var errors = new Dictionary<ValidationErrorCode, string>();

            var book = await _context.Books
                .Include(b => b.Publisher)
                .Include(b => b.AuthorBooks)
                .ThenInclude(ab => ab.Author)
                .FirstOrDefaultAsync(b => b.Id == updatedBook.Id);

            if (book != null)
            {
                book.Title = updatedBook.Title;
                book.Description = updatedBook.Description;
                book.Pages = updatedBook.Pages;
                book.Price = updatedBook.Price;
                book.Image = updatedBook.Image;

                var publisher = await _context.Publishers.FirstOrDefaultAsync(p => p.Id == updatedBook.PublisherId);
                
                if (publisher != null)
                {
                    book.Publisher = publisher;
                } else
                {
                    transaction.Rollback();
                    errors.Add(ValidationErrorCode.ReferenceAuthorsAndPublisher, "Publisher doesn't exist!");
                    throw new BookServiceExceptionHandler(errors);
                }
                
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (UniqueConstraintException ex)
                {
                    transaction.Rollback();
                    errors.Add(ValidationErrorCode.CreateBookTitle, $"{ex.Message}: Book title already exists!");
                    throw new BookServiceExceptionHandler(errors);
                }
                
                ICollection<AuthorBook> authorBooks = await _context.AuthorBooks.Where(ab => ab.BookId == book.Id).ToListAsync();

                foreach (AuthorBook authorBook in authorBooks)
                {
                    if (!updatedBook.Authors.Contains(authorBook.AuthorId.GetValueOrDefault()))
                    {
                        _context.AuthorBooks.Remove(authorBook);
                    }
                    else
                    {
                        updatedBook.Authors.Remove(authorBook.AuthorId.GetValueOrDefault());
                    }
                }

                if (updatedBook.Authors.Count() > 0)
                {
                    foreach (var authorId in updatedBook.Authors)
                    {
                        _context.AuthorBooks.Add(new AuthorBook() { BookId = book.Id, AuthorId = authorId });
                        try
                        {
                            await _context.SaveChangesAsync();
                        }
                        catch (ReferenceConstraintException ex)
                        {
                            transaction.Rollback();
                            errors.Add(ValidationErrorCode.ReferenceAuthorsAndPublisher, $"{ex.Message}: Check the ids of Authors!");
                            throw new BookServiceExceptionHandler(errors);
                        }
                    }
                }

                transaction.Commit();


                return _mapper.Map<GetBookDto>(await _context.Books
                    .Include(b => b.Publisher)
                    .Include(b => b.AuthorBooks)
                    .ThenInclude(ab => ab.Author)
                    .FirstOrDefaultAsync(b => b.Id == updatedBook.Id));

            }  
            else
            {
                transaction.Rollback();
                errors.Add(ValidationErrorCode.BookNotFound, "Book not found!");
                throw new BookServiceExceptionHandler(errors);
            }
        }
    }
}
