using MyWebAPICore.Dtos.Book;

namespace MyWebAPICore.Dtos.Author
{
    public class GetAuthorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Biography { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public bool Deleted { get; set; }

        public ICollection<GetBookDto> Books { get; set; }
    }
}
