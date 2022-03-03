namespace MyWebAPICore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; } = "noimg";
        public int Pages { get; set; }
        public double Price { get; set; }
        public bool Deleted { get; set; }

        public int? PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public List<AuthorBook> AuthorBooks { get; set; }


    }
}
