using MyWebAPICore.Dtos.Author;
using MyWebAPICore.Dtos.Publisher;

namespace MyWebAPICore.Dtos.Book
{
    public class GetBookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Pages { get; set; }
        public double Price { get; set; }
        public bool Deleted { get; set; }

        public ICollection<GetAuthorDto> Authors { get; set;}
        public GetPublisherDto Publisher { get; set; }
    }
}
