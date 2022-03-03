namespace MyWebAPICore.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }

        public int? PublisherAddressId { get; set; }
        public PublisherAddress PublisherAddress { get; set; }



    }
}
