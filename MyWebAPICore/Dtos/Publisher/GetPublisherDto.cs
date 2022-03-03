using MyWebAPICore.Dtos.PublisherAddress;

namespace MyWebAPICore.Dtos.Publisher
{
    public class GetPublisherDto
    {
        public string Name { get; set; }
        public bool Deleted { get; set; }

        public GetPublisherAddressDto PublisherAddress { get; set; }

    }
}
