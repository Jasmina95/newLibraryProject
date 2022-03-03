using MyWebAPICore.Dtos.Publisher;

namespace MyWebAPICore.Dtos.Book
{
    public class AddBookDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Pages { get; set; }
        public double Price { get; set; }

        public ICollection<int> Authors { get; set; }
        public int PublisherId { get; set; }
    }
}
