using API.Data.Services.Base;

namespace API.Data.Services.PcCase;

public class PcCaseService : BaseService<Models.PcCase>, IPcCaseService
{
    private readonly AppDbContext _context;

    public PcCaseService(AppDbContext context) : base(context)
    {
    }
}