using API.Data.Services.Base;
using API.Models;

namespace API.Data.Services.RAM;

public class RAMService : BaseService<Ram>, IRAMService
{
    private readonly AppDbContext _context;

    public RAMService(AppDbContext context) : base(context)
    {
        _context = context;
    }
}