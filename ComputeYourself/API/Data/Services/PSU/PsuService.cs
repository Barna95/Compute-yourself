using API.Data.Services.Base;
using API.Models;

namespace API.Data.Services.PSU;

public class PsuService : BaseService<Psu>, IPsuService
{
    private readonly AppDbContext _context;

    public PsuService(AppDbContext context) : base(context)
    {
        _context = context;
    }
}