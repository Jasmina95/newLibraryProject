namespace MyWebAPICore.Models
{
    public class PublisherAddress
    {
        public int Id { get; set; }
        public string Road { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Publisher Publisher { get; set; }

    }
}
