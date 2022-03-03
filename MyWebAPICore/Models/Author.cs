namespace MyWebAPICore.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Biography { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public bool Deleted { get; set; }

        public List<AuthorBook> AuthorBooks { get; set; }

    }
}
