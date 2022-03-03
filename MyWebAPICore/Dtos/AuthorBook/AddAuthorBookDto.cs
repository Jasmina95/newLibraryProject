using MyWebAPICore.Dtos.Author;

namespace MyWebAPICore.Dtos.AuthorBook
{
    public class AddAuthorBookDto
    {
        public int AuthorId { get; set; }
        public int BookId { get; set; }
    }
}
