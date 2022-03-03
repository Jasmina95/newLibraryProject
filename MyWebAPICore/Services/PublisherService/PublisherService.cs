using AutoMapper;
using MyWebAPICore.Data;

namespace MyWebAPICore.Services.PublisherService
{
    public class PublisherService : IPublisherService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public PublisherService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
