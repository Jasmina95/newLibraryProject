using AutoMapper;
using MyWebAPICore.Data;

namespace MyWebAPICore.Services.AuthorService
{
    public class AuthorService : IAuthorService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public AuthorService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
